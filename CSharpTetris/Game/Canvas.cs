using CSharpTetris.Objects;
using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Game
{
    public class Canvas
    {
        public const int CANVAS_WIDTH = 10;
        public const int CANVAS_HEIGHT = 20;

        private List<int[]> _body;
        public List<int[]> Body => _body;

        private Panel _panel;

        private List<Image> _shapeBackgrounds = new List<Image>
        {
            null,
            Resources.blue_block,
            Resources.cyan_block,
            Resources.pink_block,
            Resources.yellow_block,
            Resources.green_block,
            Resources.purple_block,
            Resources.red_block
        };

        public Canvas(Panel canvasPanel)
        {
            _body = new List<int[]>();
            _panel = canvasPanel;
        }

        public void InitializeCanvas()
        {
            _panel.Controls.Clear();
            _body.Clear();

            for (int i = 0; i < CANVAS_HEIGHT; i++)
            {
                _body.Add(new int[CANVAS_WIDTH]);
            }
        }

        public void UpdateCanvas()
        {
            _panel.Controls.Clear();
            for (int i = 0; i < _body.Count; i++)
            {
                for (int j = 0; j < _body[i].Length; j++)
                {
                    if (_body[i][j] > 0)
                    {
                        Block block = new Block(j, i, _shapeBackgrounds[_body[i][j]]);
                        block.UpdateLocation();
                        _panel.Controls.Add(block);
                    }
                }
            }
        }

        public void AddShape(BaseShape shape)
        {
            _panel.Controls.Add(shape);
        }
    }
}
