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
    public partial class EditClientForm : Form
    {
        public bool saveChanges = false;
        public bool delete = false;
        public Client editedClient = new Client();
        public EditClientForm(Client client)
        {
            InitializeComponent();
            editedClient.ID = client.ID;
            nameTextBox.Text = client.Name;
            creditAmountTextBox.Text = Convert.ToString(client.CreditAmount);
            creditTypeListBox.SelectedIndex = (int)client.creditType;
            termTextBox.Text = Convert.ToString(client.Term);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length != 0 && creditAmountTextBox.Text.Length != 0 && termTextBox.Text.Length != 0)
            {
                createButton.Enabled = true;
            }
            else
            {
                createButton.Enabled = false;
            }
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
            saveChanges = true;
            editedClient.Name = nameTextBox.Text;
            editedClient.CreditAmount = Convert.ToInt32(creditAmountTextBox.Text);
            editedClient.creditType = (Client.CreditType)creditTypeListBox.SelectedIndex;
            editedClient.Term = Convert.ToInt32(termTextBox.Text);
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete = true;
            this.Close();
        }
    }
}
