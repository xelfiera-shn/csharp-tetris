using CSharpTetris.Objects;
using CSharpTetris.Objects.Shapes;
using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Game
{
    public class GameManager
    {
        public bool IsRunning { get; private set; }

        private float _gameSpeed = 1f;

        private System.Windows.Forms.Timer _tmrGameFlow;

        private Button _btnStart;

        private Canvas _canvas;

        private Panel _nextPanel;

        private Panel _holdPanel;

        private BaseShape _currentShape;

        private BaseShape _nextShape;

        private BaseShape _holdedShape;

        private bool isHolded;

        private Label _lineScoreLabel;
        private int _lineScoreCounter;

        private Label _levelLabel;
        private int _levelCounter = 1;
        private int _levelUpCounter;

        private Label _scoreLabel;
        private int _scoreCounter;

        public GameManager(Button btnStart, Panel canvasPanel, Panel nextPanel, Panel holdPanel, Label lblLineScore, Label lblLevel, Label lblScore)
        {
            _btnStart = btnStart;

            _canvas = new Canvas(canvasPanel);
            _nextPanel = nextPanel;
            _holdPanel = holdPanel;

            _lineScoreLabel = lblLineScore;
            _levelLabel = lblLevel;
            _scoreLabel = lblScore;

            _tmrGameFlow = new();
            _tmrGameFlow.Interval = Convert.ToInt32(_gameSpeed * 1000);
            _tmrGameFlow.Tick += _tmrGameFlow_Tick;
        }

        public void StartGame()
        {
            IsRunning = true;

            _lineScoreCounter = 0;
            _levelCounter = 1;
            _levelUpCounter = 0;
            _scoreCounter = 0;

            _canvas.InitializeCanvas();
            _canvas.UpdateCanvas();

            _nextPanel.Controls.Clear();
            _holdPanel.Controls.Clear();

            _currentShape = null;
            _nextShape = null;
            _holdedShape = null;
            
            _tmrGameFlow.Start();

            _currentShape = GenerateRandomShape();
            _currentShape.UpdateLocation();
            _canvas.AddShape(_currentShape);

            GenerateNextShape();
        }

        private void _tmrGameFlow_Tick(object sender, EventArgs e)
        {
            if (!IsCollision(0, +1, false))
            {
                _currentShape.ChangeLocation("DOWN");
            }

            else
            {
                ShapeFell();

                if (IsGameOver())
                {
                    GameOver();
                }
            }
        }

        private bool IsCollision(int dX, int dY, bool isRotating)
        {
            // TODO: Rotating collision bug fix!
            bool isCollision = false;
            for (int i = 0; i < _currentShape.Controls.Count; i++)
            {
                int blockLocationX = _currentShape.OutlinePosition.X + ((Block)_currentShape.Controls[i]).InnerPosition.X + dX;
                int blockLocationY = _currentShape.OutlinePosition.Y + ((Block)_currentShape.Controls[i]).InnerPosition.Y + dY;

                if (blockLocationY >= Canvas.CANVAS_HEIGHT)
                {
                    isCollision = true;
                    break;
                }

                else if (blockLocationX < 0)
                {
                    isCollision = true;

                    if (isRotating)
                    {
                        _currentShape.ChangeLocation("RIGHT");
                    }

                    break;
                }

                else if (blockLocationX >= Canvas.CANVAS_WIDTH)
                {
                    isCollision = true;

                    if (isRotating)
                    {
                        _currentShape.ChangeLocation("LEFT");
                    }

                    break;
                }

                else if (_canvas.Body[blockLocationY][blockLocationX] > 0)
                {
                    isCollision = true;

                    if (isRotating)
                    {
                        _currentShape.ChangeRotation("NEXT");
                    }

                    break;
                }
            }

            return isCollision;
        }

        private void ShapeFell()
        {
            for (int i = 0; i < _currentShape.Controls.Count; i++)
            {
                int blockLocationX = _currentShape.OutlinePosition.X + ((Block)_currentShape.Controls[i]).InnerPosition.X;
                int blockLocationY = _currentShape.OutlinePosition.Y + ((Block)_currentShape.Controls[i]).InnerPosition.Y;

                _canvas.Body[blockLocationY][blockLocationX] = _currentShape.Value;
            }

            _scoreCounter += _currentShape.Value * 4;

            CheckLineScore();

            if (_levelUpCounter / 10 > 0)
            {
                _tmrGameFlow.Interval = Convert.ToInt32(_gameSpeed * 500);
                _levelCounter++;
                _levelUpCounter -= 10;
            }

            UpdateScoreBoard();

            _canvas.UpdateCanvas();

            _currentShape = _nextShape;
            _currentShape.UpdateLocation();
            _canvas.AddShape(_currentShape);

            GenerateNextShape();

            isHolded = false;
        }

        private void CheckLineScore()
        {
            int lines = 0;
            for (int i = 0; i < Canvas.CANVAS_HEIGHT; i++)
            {
                bool isLineScore = true;
                int lineValue = 0;
                for (int j = 0; j < Canvas.CANVAS_WIDTH; j++)
                {
                    if (_canvas.Body[i][j] == 0)
                    {
                        isLineScore = false;
                        lineValue = 0;
                        break;
                    }

                    else
                    {
                        lineValue += _canvas.Body[i][j];
                    }
                }

                if (isLineScore)
                {
                    _canvas.Body.RemoveAt(i);
                    _canvas.Body.Insert(0, new int[Canvas.CANVAS_WIDTH]);

                    lines++;
                    _lineScoreCounter++;
                    _levelUpCounter++;
                    _scoreCounter += lineValue;
                }
            }

            if (lines == 4) // Tetris score.
            {
                _scoreCounter += 400;
            }
        }

        private BaseShape GenerateRandomShape()
        {
            List<BaseShape> shapes = new List<BaseShape>
            {
                new ShapeI(),
                new ShapeJ(),
                new ShapeL(),
                new ShapeO(),
                new ShapeS(),
                new ShapeT(),
                new ShapeZ()
            };

            Random random = new Random();
            int index = random.Next(0, 7);

            return shapes[index];
        }

        private void GenerateNextShape()
        {
            _nextShape = GenerateRandomShape();
            _nextShape.Location = new Point((_nextPanel.Width - _nextShape.Width) / 2, (_nextPanel.Height - _nextShape.Height) / 2 + 15);
            _nextPanel.Controls.Add(_nextShape);
        }

        public void ShapeControls(Keys key)
        {
            switch (key)
            {
                case ControlKeys.MOVE_LEFT_KEY:
                    if (!IsCollision(-1, 0, false))
                    {
                        _currentShape.ChangeLocation("LEFT");
                    }
                    break;

                case ControlKeys.MOVE_RIGHT_KEY:
                    if (!IsCollision(+1, 0, false))
                    {
                        _currentShape.ChangeLocation("RIGHT");
                    }
                    break;

                case ControlKeys.SOFT_DROP_KEY:
                    _tmrGameFlow.Interval = Convert.ToInt32(_gameSpeed * 100);
                    break;

                case ControlKeys.HARD_DROP_KEY:
                    while (!IsCollision(0, +1, false))
                    {
                        _currentShape.ChangeLocation("DOWN");
                    }
                    ShapeFell();
                    break;

                case ControlKeys.NEXT_ROTATION_KEY:
                    _currentShape.ChangeRotation("NEXT");
                    while (IsCollision(0, 0, true))
                    {
                        continue;
                    }
                    break;

                case ControlKeys.PREV_ROTATION_KEY:
                    _currentShape.ChangeRotation("PREVIOUS");
                    while (IsCollision(0, 0, true))
                    {
                        continue;
                    }
                    break;

                case ControlKeys.HOLD_KEY:
                    if (!isHolded)
                    {
                        _canvas.UpdateCanvas();

                        if (_holdedShape == null)
                        {
                            _holdedShape = _currentShape;
                            _currentShape = _nextShape;
                            GenerateNextShape();
                        }

                        else
                        {
                            BaseShape tempShape = _currentShape;
                            _currentShape = _holdedShape;
                            _holdedShape = tempShape;
                        }

                        _holdedShape.Location = new Point((_holdPanel.Width - _holdedShape.Width) / 2, (_holdPanel.Height - _holdedShape.Height) / 2 + 15);
                        _holdedShape.CurrentRotationIndex = 0;
                        _holdPanel.Controls.Add(_holdedShape);

                        _currentShape.OutlinePosition = _currentShape.SpawnPosition;
                        _currentShape.CurrentRotationIndex = 0;
                        _currentShape.UpdateLocation();
                        _canvas.AddShape(_currentShape);

                        isHolded = true;
                    }
                    break;

                default:
                    break;
            }
        }

        public void SetDefaultInterval()
        {
            _tmrGameFlow.Interval = Convert.ToInt32(_gameSpeed * 1000);
        }

        public void UpdateScoreBoard()
        {
            _lineScoreLabel.Text = _lineScoreCounter.ToString();
            _levelLabel.Text = _levelCounter.ToString();
            _scoreLabel.Text = _scoreCounter.ToString();
        }

        public bool IsGameOver()
        {
            bool isGameOver = false;
            for (int i = 0; i < _currentShape.Controls.Count; i++)
            {
                int blockLocationX = _currentShape.OutlinePosition.X + ((Block)_currentShape.Controls[i]).InnerPosition.X;
                int blockLocationY = _currentShape.OutlinePosition.Y + ((Block)_currentShape.Controls[i]).InnerPosition.Y;

                if (blockLocationY == 0 && _canvas.Body[0][blockLocationX] > 0)
                {
                    _currentShape.OutlinePosition = new Point(_currentShape.OutlinePosition.X, _currentShape.OutlinePosition.Y - 1);
                    isGameOver = true;
                }
            }

            return isGameOver;
        }

        public void GameOver()
        {
            _tmrGameFlow.Stop();
            IsRunning = false;
            MessageBox.Show($"Game Over! Your score: {_scoreCounter}");
            _btnStart.Enabled = true;
        }
    }
}
