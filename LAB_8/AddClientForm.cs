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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
            creditTypeListBox.SelectedIndex = 0;
        }

        private Client addedClient = null;
        public Client AddedClient
        {
            get { return addedClient; }
            set { addedClient = value; }
        }
        private void textBoxOnlyNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBoxOnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l != '\b') && (l != '.') && (l != ' '))
            {
                e.Handled = true;
            }
        }



        private void createButton_Click(object sender, EventArgs e)
        {
            addedClient = new Client();
            addedClient.Name = nameTextBox.Text;
            addedClient.CreditAmount = Convert.ToInt32(creditAmountTextBox.Text);
            addedClient.creditType = (Client.CreditType)creditTypeListBox.SelectedIndex;
            addedClient.Term = Convert.ToInt32(termTextBox.Text);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length != 0 && creditAmountTextBox.Text.Length != 0 && termTextBox.Text.Length != 0)
            {
                if (toBeginButton.Checked || toEndButton.Checked || (toPositionButton.Checked && (int)positionUpDown.Value >= 0 && (int)positionUpDown.Value <= positionUpDown.Maximum))
                {
                    createButton.Enabled = true;
                }
                else
                {
                    createButton.Enabled = false;
                }
            }
            else
            {
                createButton.Enabled = false;
            }
        }
    }
}
