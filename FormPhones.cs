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
    public partial class FormPhones : Form
    {
        public FormPhones()
        {
            InitializeComponent();
            ShowPhones();
            comboBoxManufacturerer.SelectedIndex = 0;
            comboBoxSD.SelectedIndex = 0;
            comboBoxNFC.SelectedIndex = 0;
            comboBoxFinger.SelectedIndex = 0;
            comboBoxFace.SelectedIndex = 0;
        }

        void ShowPhones()
        {
            //Очищаем listView
            listViewPhones.Items.Clear();
            //Проходим по коллекции клиентов в базе с помощью foreach
            foreach (Phones phones in Program.csdb.Phones)
            {
                //Создаём новый элемент для listView из нового массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //Добавляем данные
                    phones.Id.ToString(),
                    comboBoxManufacturerer.Items[phones.Manufacturer].ToString(),
                    phones.Name,
                    phones.Camera.ToString(),
                    phones.Memory.ToString(),
                    phones.SimCount.ToString(),
                    comboBoxSD.Items[phones.SdCard].ToString(),
                    comboBoxNFC.Items[phones.NFC].ToString(),
                    comboBoxFinger.Items[phones.FingerPrint].ToString(),
                    comboBoxFace.Items[phones.FaceID].ToString(),
                    phones.Price.ToString()
                });
                //Указывваем по какому тегу будем брать элементы
                item.Tag = phones;
                //Добавляем клиента в listView
                listViewPhones.Items.Add(item);
            }
            //Выравниваем колонки в listView
            listViewPhones.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если был выбран один элемент
            if (listViewPhones.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Phones phones = listViewPhones.SelectedItems[0].Tag as Phones;
                //Указываем, что может быть изменено
                comboBoxManufacturerer.SelectedIndex = phones.Manufacturer;
                textBoxName.Text = phones.Name;
                textBoxMemory.Text = phones.Memory.ToString();
                textBoxPrice.Text = phones.Price.ToString();
                textBoxSimcount.Text = phones.SimCount.ToString();
                comboBoxSD.SelectedIndex = phones.SdCard;
                comboBoxNFC.SelectedIndex = phones.NFC;
                comboBoxFinger.SelectedIndex = phones.FingerPrint;
                comboBoxFace.SelectedIndex = phones.FaceID;
                textBoxCamera.Text = phones.Camera.ToString();
            }
            else
            {
                //Иначе очищаем поля для ввода
                comboBoxManufacturerer.SelectedIndex = 0;
                textBoxName.Text = "";
                textBoxMemory.Text = "";
                textBoxPrice.Text = "";
                textBoxSimcount.Text = "";
                comboBoxSD.SelectedIndex = 0;
                comboBoxNFC.SelectedIndex = 0;
                comboBoxFinger.SelectedIndex = 0;
                comboBoxFace.SelectedIndex = 0;
                textBoxCamera.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxCamera.Text != "" && textBoxPrice.Text != "" && textBoxMemory.Text != "" && textBoxSimcount.Text != "")
            {
                //Новый экземпляр класса Оператор связи
                Phones phones = new Phones();
                //Заполняем его данными
                phones.Manufacturer = comboBoxManufacturerer.SelectedIndex;
                phones.Name = textBoxName.Text;
                phones.Memory = Convert.ToInt32(textBoxMemory.Text);
                phones.Price = Convert.ToDouble(textBoxPrice.Text);
                phones.SimCount = Convert.ToInt32(textBoxSimcount.Text);
                phones.SdCard = comboBoxSD.SelectedIndex;
                phones.NFC = comboBoxNFC.SelectedIndex;
                phones.FingerPrint = comboBoxFinger.SelectedIndex;
                phones.FaceID = comboBoxFace.SelectedIndex;
                phones.Camera = Convert.ToDouble(textBoxCamera.Text);
                //Добавляем в таблицу ClientsSet нового клиента clientsSet
                Program.csdb.Phones.Add(phones);
                //Сохраняем изменения
                Program.csdb.SaveChanges();
                //Обновляем listView
                ShowPhones();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Если выбран один элемент из listView
            if (listViewPhones.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Phones phones = listViewPhones.SelectedItems[0].Tag as Phones;
                //Обновляем его данные
                phones.Manufacturer = comboBoxManufacturerer.SelectedIndex;
                phones.Name = textBoxName.Text;
                phones.Memory = Convert.ToInt32(textBoxMemory.Text);
                phones.Price = Convert.ToDouble(textBoxPrice.Text);
                phones.SimCount = Convert.ToInt32(textBoxSimcount.Text);
                phones.SdCard = comboBoxSD.SelectedIndex;
                phones.NFC = comboBoxNFC.SelectedIndex;
                phones.FingerPrint = comboBoxFinger.SelectedIndex;
                phones.FaceID = comboBoxFace.SelectedIndex;
                phones.Camera = Convert.ToDouble(textBoxCamera.Text);
                //Сохраняем изменения
                Program.csdb.SaveChanges();
                //Обновляем listView
                ShowPhones();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Пробуем удалить телефон
            try
            {
                //Если выбран один элемент из listView
                if (listViewPhones.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Phones phones = listViewPhones.SelectedItems[0].Tag as Phones;
                    //И удаляем его из модели и базы данных
                    Program.csdb.Phones.Remove(phones);
                    //Сохраняем изменения
                    Program.csdb.SaveChanges();
                    //Обновляем listView
                    ShowPhones();
                }
                //Очищаем поля для ввода
                comboBoxManufacturerer.SelectedIndex = 0;
                textBoxName.Text = "";
                textBoxMemory.Text = "";
                textBoxPrice.Text = "";
                textBoxSimcount.Text = "";
                comboBoxSD.SelectedIndex = 0;
                comboBoxNFC.SelectedIndex = 0;
                comboBoxFinger.SelectedIndex = 0;
                comboBoxFace.SelectedIndex = 0;
                textBoxCamera.Text = "";
            }
            //Если удалить не получилось, например если запись используется, выводим сообщение
            catch
            {
                MessageBox.Show("Невозможно удалить запись, возможно она используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
