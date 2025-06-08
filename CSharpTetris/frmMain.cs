using CSharpTetris.Game;
using CSharpTetris.Objects.Shapes;

namespace CSharpTetris
{
    public partial class frmMain : Form
    {
        private GameManager _gameManager;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _gameManager = new GameManager(btnStart, pnlCanvas, pnlNext, pnlHold, lblLines, lblLevel, lblScore);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _gameManager.StartGame();
            btnStart.Enabled = false;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (_gameManager.IsRunning)
            {
                _gameManager.ShapeControls(e.KeyCode);
            }
        }
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (_gameManager.IsRunning)
            {
                _gameManager.SetDefaultInterval();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
