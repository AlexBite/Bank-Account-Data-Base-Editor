using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB_8
{
    public partial class MainForm : Form
    {
        List<Client> clientList = new List<Client>();

        public MainForm()
        {
            InitializeComponent();
            sortListBox.SelectedIndex = 0;
        }
        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.positionUpDown.Maximum = clientList.Count;
            addClientForm.ShowDialog();
            AddClient(ref addClientForm);
            addClientForm.Close();
            ShowData();
        }

        // Вывод списка клиентов:
        private void ShowData()
        {
            dataGridView1.Rows.Clear();
            foreach (var i in clientList)
            {
                dataGridView1.Rows.Add(i.ID, i.Name, i.CreditAmount, i.creditType, i.Term);
            }
        }

        // Добавление клиента в список:
        private void AddClient(ref AddClientForm addClientForm)
        {
            if (addClientForm.AddedClient != null)
            {
                addClientForm.AddedClient.ID = clientList.Count;
                if (addClientForm.toBeginButton.Checked == true)
                {
                    clientList.Insert(0, addClientForm.AddedClient);
                }
                else if (addClientForm.toEndButton.Checked == true)
                {
                    clientList.Add(addClientForm.AddedClient);
                }
                else if (addClientForm.toPositionButton.Checked == true)
                {
                    clientList.Insert(Convert.ToInt32(addClientForm.positionUpDown.Value), addClientForm.AddedClient);
                }
            }
        }

        // Редактировать/удалить запись:
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetIDForm getIDForm = new GetIDForm();              // Создаём форму для получения ID записи
            getIDForm.idUpDown.Maximum = clientList.Count - 1;  // Передаём максимальное значение ID
            getIDForm.ShowDialog();                             // Вывод формы

            if (getIDForm.buttonPressed)    // Если форма закрылась от нажатия кнопки
            {
                int found = clientList.FindIndex(item => item.ID == (int)getIDForm.idUpDown.Value);
                EditClientForm editClientForm = new EditClientForm(clientList[found]);
                editClientForm.ShowDialog();

                if (editClientForm.saveChanges)     // Если была нажата кнопка "Сохранить"
                {
                    clientList[found] = editClientForm.editedClient;
                }
                else if (editClientForm.delete)     // Если была нажата кнопка "Удалить"
                {
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        if (clientList[found].ID < clientList[i].ID)
                        {
                            clientList[i].ID += -1;
                        }
                    }
                    clientList.Remove(clientList[found]);
                }
            }
            ShowData();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<Client> tempList = new List<Client>();
            int type = sortListBox.SelectedIndex;

            foreach (var i in clientList)
            {
                if (i.creditType == (Client.CreditType)type)
                {
                    tempList.Add(i);
                }
            }

            SortedForm sortedForm = new SortedForm(tempList);
            sortedForm.Text = Convert.ToString((Client.CreditType)type);
            sortedForm.Show();
        }

        // Найти топ-заёмщика
        private void searchButton_Click(object sender, EventArgs e)
        {
            FindTopCreditor();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenList();
        }

        private void SaveList()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, clientList);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Файл не сохранён!");
            }
        }

        // Вывод записей из файла на dataGridView
        private void OpenList()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    clientList = (List<Client>)formatter.Deserialize(fs);
                    ShowData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при чтении файла!");
                }
            }
            else
            {
                MessageBox.Show("Файл не открыт!");
            }
        }

        private void FindTopCreditor()
        {
            if (clientList.Count != 0)
            {
                List<Client> clientDebt = new List<Client>();
                int indx = 0;
                foreach (Client c in clientList)
                {
                    indx = clientDebt.FindIndex((item) => item.Name == c.Name); // Проверяем есть ли подобная запись в clientDebt, если нет, то -1
                    if (indx == -1)
                    {
                        clientDebt.Add(c);
                    }
                    else
                    {
                        clientDebt[indx].CreditAmount += c.CreditAmount;
                    }
                }
                int max = clientDebt.Max(item => item.CreditAmount);
                Client Max = clientDebt.Find(item => item.CreditAmount == max);
                TopCreditForm TopCredit = new TopCreditForm();
                TopCredit.nameTextBox.Text = Max.Name;
                TopCredit.summTextBox.Text = Convert.ToString(Max.CreditAmount);
                TopCredit.ShowDialog();
            }
        }
    }
}
