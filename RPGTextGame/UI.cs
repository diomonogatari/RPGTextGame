using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleControl;
using System.Threading;

namespace RPGTextGame
{

    public partial class UI : Form
    {

        public static Color buttonForeColor = Color.White;
        public static Color buttonBackColor = Color.Black;
        public static Color colorOfTextToPaint = Color.AliceBlue;
        public static string textThatWasChoosenToWrite = "";
        public bool userWantsToLeave = false;
        CharacterHero testHero;
        OpeningNarrative open;




        public UI()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;//Makes it "fullscreen"
            this.KeyPreview = true;

            testHero = new CharacterHero("Anon", 500, 100, 50, 10, 25, 5, 1, 5, 10, "Your clothes are filthy, and there's cuts and blood all over your body", 0, Color.Red, consoleDialog);
            open = new OpeningNarrative(testHero);





            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            btn1.ForeColor = buttonForeColor;
            btn1.BackColor = buttonBackColor;

            btn2.ForeColor = buttonForeColor;
            btn2.BackColor = buttonBackColor;

            btn3.ForeColor = buttonForeColor;
            btn3.BackColor = buttonBackColor;

            btn4.ForeColor = buttonForeColor;
            btn4.BackColor = buttonBackColor;




        }

        #region UI events
        private void UI_Load(object sender, EventArgs e)
        {

            UIDrawing();
            createProccesInfo();

        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userWantsToLeave = true;
                    thrLeaveGame.RunWorkerAsync();
                }
            }
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Esc to leave\n\nF5 to clean screen", "Help");
            if (e.KeyCode == Keys.F5)
                consoleDialog.ClearOutput();
        }
        #endregion




        #region Helping Methods

        private void createProccesInfo()
        {
            consoleDialog.StartProcess(this.Name, "");
            consoleDialog.WriteOutput("For help press F1\n", Color.White);
        }

        private void killProcces()
        {
            consoleDialog.StopProcess();
            Thread.Sleep(500);
        }




        private void UIDrawing()
        {
            int x = this.Width; //form width
            int h = this.Height; //form height
            int numberOfButtons = howManyButtons(this);

            consoleDialog.Font = new Font(consoleDialog.Font.FontFamily, 20);
            consoleDialog.InternalRichTextBox.ReadOnly = true;



            this.BackColor = Color.Black;
            consoleDialog.Location = new Point(1, 0);
            consoleDialog.BackColor = Color.Black;
            consoleDialog.ForeColor = Color.White;
            consoleDialog.BorderStyle = BorderStyle.Fixed3D;
            consoleDialog.Size = new Size(Convert.ToInt32(this.Width * 1), Convert.ToInt32(this.Height * 0.8));
            btn1.Size = new Size(Convert.ToInt32(0.8 * (x / numberOfButtons)), Convert.ToInt32(h / 10));
            int margins = (x / numberOfButtons - btn1.Size.Width) / 2;

            btn1.Location = new Point(margins, Convert.ToInt32(8.3 * (this.Height / 10)));
            btn2.Size = btn1.Size;
            btn2.Location = new Point((x / numberOfButtons) + margins, Convert.ToInt32(8.3 * (this.Height / 10)));

            btn3.Size = btn1.Size;
            btn3.Location = new Point(2 * (x / numberOfButtons) + margins, Convert.ToInt32(8.3 * (this.Height / 10)));

            btn4.Size = btn1.Size;
            btn4.Location = new Point(3 * (x / numberOfButtons) + margins, Convert.ToInt32(8.3 * (this.Height / 10)));



        }

        public static int howManyButtons(UI ui)
        {
            int numberOfButtons = 0;
            foreach (Control b in ui.Controls)
            {
                if (b.GetType() == typeof(Button))
                    numberOfButtons++;
            }
            return numberOfButtons;
        }

        private void changeButtonsEnabledTo(bool valueDesired)
        {
            foreach (Control b in this.Controls)
                if (b.GetType() == typeof(Button))
                    b.Enabled = valueDesired;
        }

        #endregion

        #region Button click events
        private void btn1_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledTo(false);
            thrButtons.RunWorkerAsync("Opt 1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledTo(false);
            thrButtons.RunWorkerAsync("Opt 2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledTo(false);
            thrButtons.RunWorkerAsync("Opt 3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledTo(false);
            thrButtons.RunWorkerAsync("Opt 4");
        }
        #endregion


        #region Background threads

        #region Buttons Thread
        private void thrButtons_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            changeButtonsEnabledTo(true);


        }

        private void thrButtons_DoWork(object sender, DoWorkEventArgs e)
        {
            var debug = sender.GetType();
            switch (e.Argument.ToString())
            {
                case "Opt 1":
                    testHero.LookSelf();

                    break;
                case "Opt 2":
                    open.Start();

                    break;
                case "Opt 3":
                    Core.Write("this is button 3, it writes a slow text", consoleDialog, Color.Blue, 50);

                    break;
                case "Opt 4":
                    testHero.UseItem(new UsableItem("A Health Potion", "You feel vitalized", TypesOfStats.HP, 100));

                    break;
                default:
                    Core.Write("ERROR", consoleDialog, Color.White, 10);
                    break;
            }
        }
        #endregion

        #region Leaving Thread
        private void thrLeaveGame_DoWork(object sender, DoWorkEventArgs e)
        {
            killProcces();
        }
        private void thrLeaveGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion



    }
}
