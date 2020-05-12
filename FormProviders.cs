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
    public partial class FormProviders : Form
    {
        public FormProviders()
        {
            InitializeComponent();
            ShowProviders();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Пробуем удалить оператора
            try
            {
                //Если выбран один элемент из listView
                if (listViewProviders.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Providers providers = listViewProviders.SelectedItems[0].Tag as Providers;
                    //И удаляем его из модели и базы данных
                    Program.csdb.Providers.Remove(providers);
                    //Сохраняем изменения
                    Program.csdb.SaveChanges();
                    //Обновляем listView
                    ShowProviders();
                }
                //Очищаем поля для ввода
                textBoxProvider.Text = "";
                textBoxFee.Text = "";
            }
            //Если удалить не получилось, например если запись используется, выводим сообщение
            catch
            {
                //Всплывающее окно, с параметрами Текст, Заголовок, Кнопка ОК и иконка ошибки
                MessageBox.Show("Невозможно удалить запись, возможно она используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Если был выбран один элемент
            if (listViewProviders.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Providers providers = listViewProviders.SelectedItems[0].Tag as Providers;
                //Обновляем его данные
                providers.Name = textBoxProvider.Text;
                providers.Fee = Convert.ToInt32(textBoxFee.Text);
                //Сохраняем изменения
                Program.csdb.SaveChanges();
                //Обновляем listView
                ShowProviders();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxProvider.Text != "" && textBoxFee.Text != "")
            {
                //Новый экземпляр класса Оператор связи
                Providers providers = new Providers();
                //Заполняем его данными
                providers.Name = textBoxProvider.Text;
                providers.Fee = Convert.ToInt32(textBoxFee.Text);
                //Добавляем в таблицу ClientsSet нового клиента clientsSet
                Program.csdb.Providers.Add(providers);
                //Сохраняем изменения
                Program.csdb.SaveChanges();
                //Обновляем listView
                ShowProviders();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если был выбран один элемент
            if (listViewProviders.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Providers providers = listViewProviders.SelectedItems[0].Tag as Providers;
                //Указываем, что может быть изменено
                textBoxProvider.Text = providers.Name;
                textBoxFee.Text = providers.Fee.ToString();
            }
            else
            {
                //Иначе очищаем поля для ввода
                textBoxProvider.Text = "";
                textBoxFee.Text = "";
            }
        }

        void ShowProviders()
        {
            //Очищаем listView
            listViewProviders.Items.Clear();
            //Проходим по коллекции клиентов в базе с помощью foreach
            foreach (Providers providers in Program.csdb.Providers)
            {
                //Создаём новый элемент для listView из нового массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //Добавляем данные
                    providers.Id.ToString(),
                    providers.Name,
                    providers.Fee.ToString()
                });
                //Указывваем по какому тегу будем брать элементы
                item.Tag = providers;
                //Добавляем клиента в listView
                listViewProviders.Items.Add(item);
            }
            //Выравниваем колонки в listView
            listViewProviders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
