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
    public partial class SortedForm : Form
    {
        public SortedForm(List<Client> clients)
        {
            InitializeComponent();
            foreach (var i in clients)
            {
                outputGridView.Rows.Add(i.ID, i.Name, i.CreditAmount, i.creditType, i.Term);
            }
        }
    }
}
