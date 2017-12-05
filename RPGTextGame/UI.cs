using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGTextGame
{

    public partial class UI : Form
    {

        public static Color buttonForeColor = Color.White;
        public static Color buttonBackColor = Color.Black;
        int formwidth;
        int formheight;
        public static TextBox gameOutput = null;

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

        public UI()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true;

            gameOutput = txtDialog;

            formwidth = this.Width;
            formheight = this.Height;
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

        private void UI_Load(object sender, EventArgs e)
        {
            UIDrawing();
        }

        private void UI_Resize(object sender, EventArgs e)
        {
            this.Height = formheight;
            this.Width = formwidth;
        }
        private void UIDrawing()
        {
            int x = this.Width; //form width
            int h = this.Height; //form height
            int numberOfButtons = howManyButtons(this);
            this.BackColor = Color.Black;
            txtDialog.Enabled = false;
            txtDialog.Location = new Point(1, 0);
            txtDialog.BorderStyle = BorderStyle.Fixed3D;
            txtDialog.Size = new Size(Convert.ToInt32(this.Width * 1), Convert.ToInt32(this.Height * 0.8));
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

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Core.Write("this is button 1", Color.Red, txtDialog, this);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Core.Write("this is button 2", Color.Green, txtDialog, this);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Core.Write("this is button 3", Color.Blue, txtDialog,this);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Core.Write("this is button 4", Color.White, txtDialog,this);
        }
    }
}
