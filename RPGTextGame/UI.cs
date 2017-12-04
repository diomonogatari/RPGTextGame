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
        
        public UI()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            btnNext.ForeColor = Color.Aquamarine;
            btnNext.BackColor = Color.Black;

            button1.ForeColor = Color.Aquamarine;
            button1.BackColor = Color.Magenta;

            button2.ForeColor = Color.Aquamarine;
            button2.BackColor = Color.Yellow;

            button3.ForeColor = Color.Green;
            button3.BackColor = Color.Blue;

        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            txtDialog.Enabled = false;
            txtDialog.Location = new Point(0, 0);
            txtDialog.BorderStyle = BorderStyle.Fixed3D;
            txtDialog.Size = new Size(Convert.ToInt32(this.Width * 1), Convert.ToInt32(this.Height * 0.8));
        }
    }
}
