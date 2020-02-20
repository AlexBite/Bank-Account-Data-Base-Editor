using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class GetIDForm : Form
    {
        public bool buttonPressed = false;
        public GetIDForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            this.Close();
        }
    }
}
