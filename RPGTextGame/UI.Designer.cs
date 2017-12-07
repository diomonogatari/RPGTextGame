namespace RPGTextGame
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.thrButtons = new System.ComponentModel.BackgroundWorker();
            this.consoleDialog = new ConsoleControl.ConsoleControl();
            this.thrLeaveGame = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Location = new System.Drawing.Point(12, 394);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(208, 52);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Look at yourself";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn4.Location = new System.Drawing.Point(597, 394);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(178, 52);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "Use Item";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn3.Location = new System.Drawing.Point(418, 394);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(173, 52);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Opt 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.Location = new System.Drawing.Point(226, 394);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(186, 52);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Opt 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // thrButtons
            // 
            this.thrButtons.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thrButtons_DoWork);
            this.thrButtons.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thrButtons_RunWorkerCompleted);
            // 
            // consoleDialog
            // 
            this.consoleDialog.IsInputEnabled = true;
            this.consoleDialog.Location = new System.Drawing.Point(3, 2);
            this.consoleDialog.Name = "consoleDialog";
            this.consoleDialog.SendKeyboardCommandsToProcess = false;
            this.consoleDialog.ShowDiagnostics = false;
            this.consoleDialog.Size = new System.Drawing.Size(772, 386);
            this.consoleDialog.TabIndex = 6;
            // 
            // thrLeaveGame
            // 
            this.thrLeaveGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thrLeaveGame_DoWork);
            this.thrLeaveGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thrLeaveGame_RunWorkerCompleted);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(779, 458);
            this.Controls.Add(this.consoleDialog);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG Texter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UI_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.ComponentModel.BackgroundWorker thrButtons;
        private ConsoleControl.ConsoleControl consoleDialog;
        private System.ComponentModel.BackgroundWorker thrLeaveGame;
    }
}