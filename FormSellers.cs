using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellStore
{
    public partial class FormSellers : Form
    {
        public FormSellers()
        {
            InitializeComponent();
            comboBoxPosition.SelectedIndex = 0;
            ShowSellers();
        }

        void ShowSellers()
        {
            listViewSellers.Items.Clear();
            foreach (Sellers sellers in Program.csdb.Sellers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sellers.Id.ToString(),
                    sellers.Lastname,
                    sellers.Firstname,
                    sellers.Lastname,
                    sellers.Positions.Name
                });
                item.Tag = sellers;
                listViewSellers.Items.Add(item);
            }
            listViewSellers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text != "" && textBoxMiddlename.Text != "" && textBoxLastname.Text != "" && textBoxPassword.Text != "")
            {
                Users users = new Users();
                users.Login = textBoxLastname.Text;
                users.Password = textBoxPassword.Text;
                users.Type = "Seller";
                Program.csdb.Users.Add(users);
                Program.csdb.SaveChanges();
                Sellers sellers = new Sellers();
                sellers.Firstname = textBoxFirstname.Text;
                sellers.Middlename = textBoxMiddlename.Text;
                sellers.Lastname = textBoxLastname.Text;
                sellers.Position = comboBoxPosition.SelectedIndex;
                sellers.UserID = users.Id;
                Program.csdb.Sellers.Add(sellers);
                Program.csdb.SaveChanges();
                ShowSellers();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSellers.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Sellers sellers = listViewSellers.SelectedItems[0].Tag as Sellers;
                //Обновляем его данные
                sellers.Firstname = textBoxFirstname.Text;
                sellers.Middlename = textBoxMiddlename.Text;
                sellers.Lastname = textBoxLastname.Text;
                sellers.Position = comboBoxPosition.SelectedIndex;
                sellers.Users.Login = textBoxLastname.Text;
                sellers.Users.Password = textBoxPassword.Text;
                //Сохраняем изменения
                Program.csdb.SaveChanges();
                //Обновляем listView
                ShowSellers();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSellers.SelectedItems.Count == 1)
                {
                    Sellers sellers = listViewSellers.SelectedItems[0].Tag as Sellers;
                    Program.csdb.Users.Remove(sellers.Users);
                    Program.csdb.Sellers.Remove(sellers);
                    Program.csdb.SaveChanges();
                    ShowSellers();
                }
                //Очищаем поля для ввода
                textBoxFirstname.Text = "";
                textBoxMiddlename.Text = "";
                textBoxLastname.Text = "";
                textBoxPassword.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, возможно запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если был выбран один элемент
            if (listViewSellers.SelectedItems.Count == 1)
            {
                Sellers sellers = listViewSellers.SelectedItems[0].Tag as Sellers;
                textBoxFirstname.Text = sellers.Firstname;
                textBoxMiddlename.Text = sellers.Middlename;
                textBoxLastname.Text = sellers.Lastname;
                textBoxPassword.Text = sellers.Users.Password;
                comboBoxPosition.SelectedIndex = sellers.Position;
            }
            //Иначе очищаем поля для ввода
            else
            {
                textBoxFirstname.Text = "";
                textBoxMiddlename.Text = "";
                textBoxLastname.Text = "";
                textBoxPassword.Text = "";
                comboBoxPosition.SelectedIndex = 0;
            }
        }
    }
}
