namespace CSharpTetris
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnStart = new Button();
            pnlScoreBoardBorder = new Panel();
            pnlScoreBoard = new Panel();
            lblScore = new Label();
            label7 = new Label();
            lblLines = new Label();
            label6 = new Label();
            lblLevel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlHoldBorder = new Panel();
            pnlHold = new Panel();
            label1 = new Label();
            pnlNextBorder = new Panel();
            pnlNext = new Panel();
            pnlCanvasBorder = new Panel();
            pnlCanvas = new Panel();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnMinimize = new Button();
            btnExit = new Button();
            pnlMain.SuspendLayout();
            pnlScoreBoardBorder.SuspendLayout();
            pnlScoreBoard.SuspendLayout();
            pnlHoldBorder.SuspendLayout();
            pnlNextBorder.SuspendLayout();
            pnlCanvasBorder.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.SeaShell;
            pnlMain.Controls.Add(btnStart);
            pnlMain.Controls.Add(pnlScoreBoardBorder);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(pnlHoldBorder);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(pnlNextBorder);
            pnlMain.Controls.Add(pnlCanvasBorder);
            pnlMain.Controls.Add(pnlTitle);
            pnlMain.Location = new Point(5, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(549, 702);
            pnlMain.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Coral;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(352, 402);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(182, 39);
            btnStart.TabIndex = 8;
            btnStart.TabStop = false;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pnlScoreBoardBorder
            // 
            pnlScoreBoardBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlScoreBoardBorder.BackColor = Color.LightSalmon;
            pnlScoreBoardBorder.Controls.Add(pnlScoreBoard);
            pnlScoreBoardBorder.Location = new Point(352, 570);
            pnlScoreBoardBorder.Name = "pnlScoreBoardBorder";
            pnlScoreBoardBorder.Size = new Size(182, 117);
            pnlScoreBoardBorder.TabIndex = 6;
            // 
            // pnlScoreBoard
            // 
            pnlScoreBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlScoreBoard.BackColor = Color.Gainsboro;
            pnlScoreBoard.Controls.Add(lblScore);
            pnlScoreBoard.Controls.Add(label7);
            pnlScoreBoard.Controls.Add(lblLines);
            pnlScoreBoard.Controls.Add(label6);
            pnlScoreBoard.Controls.Add(lblLevel);
            pnlScoreBoard.Controls.Add(label4);
            pnlScoreBoard.Location = new Point(1, 1);
            pnlScoreBoard.Name = "pnlScoreBoard";
            pnlScoreBoard.Size = new Size(180, 115);
            pnlScoreBoard.TabIndex = 2;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.FlatStyle = FlatStyle.Flat;
            lblScore.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            lblScore.ForeColor = Color.DarkRed;
            lblScore.Location = new Point(84, 78);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(20, 24);
            lblScore.TabIndex = 13;
            lblScore.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(5, 78);
            label7.Name = "label7";
            label7.Size = new Size(76, 24);
            label7.TabIndex = 12;
            label7.Text = "SCORE:";
            // 
            // lblLines
            // 
            lblLines.AutoSize = true;
            lblLines.FlatStyle = FlatStyle.Flat;
            lblLines.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            lblLines.ForeColor = Color.DarkRed;
            lblLines.Location = new Point(84, 44);
            lblLines.Name = "lblLines";
            lblLines.Size = new Size(20, 24);
            lblLines.TabIndex = 11;
            lblLines.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(5, 44);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 10;
            label6.Text = "LINES:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.FlatStyle = FlatStyle.Flat;
            lblLevel.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            lblLevel.ForeColor = Color.DarkRed;
            lblLevel.Location = new Point(84, 11);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(20, 24);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(5, 11);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 8;
            label4.Text = "LEVEL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(352, 543);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 7;
            label3.Text = "SCORE BOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(352, 220);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 6;
            label2.Text = "HOLD";
            // 
            // pnlHoldBorder
            // 
            pnlHoldBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlHoldBorder.BackColor = Color.LightSalmon;
            pnlHoldBorder.Controls.Add(pnlHold);
            pnlHoldBorder.Location = new Point(352, 247);
            pnlHoldBorder.Name = "pnlHoldBorder";
            pnlHoldBorder.Size = new Size(182, 130);
            pnlHoldBorder.TabIndex = 5;
            // 
            // pnlHold
            // 
            pnlHold.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHold.BackColor = Color.Gainsboro;
            pnlHold.Location = new Point(1, 1);
            pnlHold.Name = "pnlHold";
            pnlHold.Size = new Size(180, 128);
            pnlHold.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(352, 45);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 4;
            label1.Text = "NEXT";
            // 
            // pnlNextBorder
            // 
            pnlNextBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNextBorder.BackColor = Color.LightSalmon;
            pnlNextBorder.Controls.Add(pnlNext);
            pnlNextBorder.Location = new Point(352, 72);
            pnlNextBorder.Name = "pnlNextBorder";
            pnlNextBorder.Size = new Size(182, 130);
            pnlNextBorder.TabIndex = 3;
            // 
            // pnlNext
            // 
            pnlNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNext.BackColor = Color.Gainsboro;
            pnlNext.Location = new Point(1, 1);
            pnlNext.Name = "pnlNext";
            pnlNext.Size = new Size(180, 128);
            pnlNext.TabIndex = 2;
            // 
            // pnlCanvasBorder
            // 
            pnlCanvasBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlCanvasBorder.BackColor = Color.LightSalmon;
            pnlCanvasBorder.Controls.Add(pnlCanvas);
            pnlCanvasBorder.Location = new Point(15, 45);
            pnlCanvasBorder.Name = "pnlCanvasBorder";
            pnlCanvasBorder.Size = new Size(322, 642);
            pnlCanvasBorder.TabIndex = 1;
            // 
            // pnlCanvas
            // 
            pnlCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCanvas.BackColor = Color.Gainsboro;
            pnlCanvas.Location = new Point(1, 1);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(320, 640);
            pnlCanvas.TabIndex = 2;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Olive;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(btnMinimize);
            pnlTitle.Controls.Add(btnExit);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(549, 30);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(7, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 19);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Tetris";
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.Location = new Point(489, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(519, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(559, 712);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            KeyDown += frmMain_KeyDown;
            KeyUp += frmMain_KeyUp;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlScoreBoardBorder.ResumeLayout(false);
            pnlScoreBoard.ResumeLayout(false);
            pnlScoreBoard.PerformLayout();
            pnlHoldBorder.ResumeLayout(false);
            pnlNextBorder.ResumeLayout(false);
            pnlCanvasBorder.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTitle;
        private Button btnExit;
        private Label lblTitle;
        private Button btnMinimize;
        private Panel pnlCanvasBorder;
        private Panel pnlCanvas;
        private Panel pnlNextBorder;
        private Panel pnlNext;
        private Label label1;
        private Label label2;
        private Panel pnlHoldBorder;
        private Panel pnlHold;
        private Panel pnlScoreBoardBorder;
        private Panel pnlScoreBoard;
        private Label label3;
        private Label lblLines;
        private Label label6;
        private Label lblLevel;
        private Label label4;
        private Label lblScore;
        private Label label7;
        private Button btnStart;
    }
}
