using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            this.MouseClick += Form_Mouseclick;

        }
        public static void Run()
        {
            Application.EnableVisualStyles();
            Application.Run(new Bai2());
        }
        public void Form_Mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Random rd = new Random();
                label1.Location = new Point(rd.Next(this.ClientSize.Width - 50), rd.Next(this.ClientSize.Height - 50));
            }
            
        }
        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
