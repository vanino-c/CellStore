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
    public partial class FormDeals : Form
    {
        public FormDeals()
        {
            InitializeComponent();
            ShowSellers();
            ShowPhones();
            ShowProviders();
            ShowDeals();
            comboBoxSd.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
            comboBoxSafe.SelectedIndex = 0;
            comboBoxCase.SelectedIndex = 0;
        }

        void ShowProviders()
        {
            foreach (Providers providers in Program.csdb.Providers)
            {
                string[] provider =
                {
                    providers.Id.ToString() + ".",
                    providers.Name + ":" + providers.Fee.ToString()
                };
                comboBoxProvider.Items.Add(string.Join(" ", provider));
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Пробуем удалить сделку
            try
            {
                //Если выбран один элемент из listView
                if (listViewDeals.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Deals deals = listViewDeals.SelectedItems[0].Tag as Deals;
                    //И удаляем его из модели и базы данных
                    Program.csdb.Deals.Remove(deals);
                    //Сохраняем изменения
                    Program.csdb.SaveChanges();
                    //Обновляем listView
                    ShowDeals();
                }
                //Очищаем поля для ввода
                comboBoxSd.SelectedIndex = 0;
                comboBoxSafe.SelectedIndex = 0;
                comboBoxCase.SelectedIndex = 0;
                comboBoxPhone.SelectedItem = null;
                textBoxPrice.Text = "0";
                textBoxTotal.Text = "0";
                textBoxColor.Text = "Чёрный";

                comboBoxProvider.SelectedItem = null;
                textBoxNumber.Text = "";
                textBoxPayment.Text = "";
            }
            //Если удалить не получилось, например если запись используется, выводим сообщение
            catch
            {
                MessageBox.Show("Невозможно удалить запись, возможно она используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ShowPhones()
        {
            comboBoxPhone.Items.Clear();
            string[] manufacturer =
            {
                "Apple",
                "Samsung",
                "Honor",
                "HTC"
            };
            string[] have =
            {
                "Нет",
                "Да",
                "Гибридный",
            };
            foreach (Phones phones in Program.csdb.Phones)
            {
                string[] phone =
                {
                    phones.Id.ToString() + ".",
                    manufacturer[phones.Manufacturer] + " " + phones.Name,
                    phones.Memory.ToString() + "гб",
                    phones.Camera.ToString() + "мпкс",
                    "Sim-карт - " + phones.SimCount,
                    "Sd-карта - " + have[phones.SdCard],
                    "NFC - " + have[phones.NFC],
                    "Отпечаток пальца - " + have[phones.FingerPrint],
                    "Сканер лица - " + have[phones.FaceID],
                    phones.Price.ToString() + "р",
                };
                comboBoxPhone.Items.Add(string.Join(" ", phone));
            }
        }

        void ShowSellers()
        {
            //Очищаем comboBox
            comboBoxSeller.Items.Clear();
            foreach (Sellers sellers in Program.csdb.Sellers)
            {
                //Добавляем Риелтора с нужной нам информацией(ID, Фамилия, инициалы, доля)
                string[] item =
                {
                    sellers.Id.ToString() + ".",
                    sellers.Lastname,
                    sellers.Firstname.Substring(0, 1) + "." + sellers.Middlename.Substring(0, 1) + "."
                };
                comboBoxSeller.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDeals()
        {
            listViewDeals.Items.Clear();
            foreach (Deals deals in Program.csdb.Deals)
            {
                if (deals.Type == 0)
                {
                    string[] data = deals.Data.Split(':');
                    //Ищем телефон в базе данных
                    Phones phones = new Phones();
                    foreach (Phones sphones in Program.csdb.Phones)
                    {
                        if (sphones.Id == Convert.ToInt32(data[0]))
                        {
                            phones = sphones;
                            break;
                        }
                    }
                    string[] manufacturer =
                    {
                        "Apple",
                        "Samsung",
                        "Honor",
                        "HTC"
                    };
                    string[] have =
                    {
                        "Нет",
                        "Да",
                        "Гибридный",
                    };
                    string[] phone =
                    {
                        phones.Id.ToString() + ".",
                        manufacturer[phones.Manufacturer] + " " + phones.Name + ",",
                        phones.Memory.ToString() + "гб,",
                        phones.Camera.ToString() + "мпкс,",
                        "Sim-карт - " + phones.SimCount + ",",
                        "Sd-карта - " + have[phones.SdCard] + ",",
                        "NFC - " + have[phones.NFC] + ",",
                        "Отпечаток пальца - " + have[phones.FingerPrint] + ",",
                        "Сканер лица - " + have[phones.FaceID] + ",",
                        phones.Price.ToString() + "р",
                    };
                    ListViewItem item = new ListViewItem(new string[] 
                    {
                        deals.Id.ToString(),
                        deals.Sellers.Id + ". " + deals.Sellers.Lastname + " " + deals.Sellers.Firstname.Substring(0, 1) + "." +  deals.Sellers.Middlename.Substring(0, 1) + ".",
                        "Телефон",
                        string.Join(" ", phone),
                        deals.Price.ToString()
                    });
                    item.Tag = deals;
                    listViewDeals.Items.Add(item);
                } 
                else
                {
                    string[] data = deals.Data.Split(':');
                    string provider = comboBoxProvider.Items[comboBoxProvider.FindString(data[0])].ToString().Split('.')[1].Split(':')[0];
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        deals.Id.ToString(),
                        deals.Sellers.Id + ". " + deals.Sellers.Lastname + " " + deals.Sellers.Firstname.Substring(0, 1) + "." +  deals.Sellers.Middlename.Substring(0, 1) + ".",
                        "Оплата связи",
                        "Оператор:" + provider + " тел: " + data[1],
                        deals.Price.ToString()
                    });
                    item.Tag = deals;
                    listViewDeals.Items.Add(item);
                }
            }
            listViewDeals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDeals.SelectedItems.Count == 1)
            {
                if (comboBoxSeller.SelectedItem != null)
                {
                    if (comboBoxType.SelectedIndex == 0)
                    {
                        if (comboBoxPhone.SelectedItem != null)
                        {
                            string[] phData =
                            {
                                comboBoxPhone.SelectedIndex.ToString(),
                                textBoxColor.Text,
                                comboBoxSd.SelectedItem.ToString().Split('г')[0],
                                comboBoxCase.SelectedIndex.ToString(),
                                comboBoxSafe.SelectedIndex.ToString()
                            };
                            string data = string.Join(":", phData);
                            Deals deals = listViewDeals.SelectedItems[0].Tag as Deals;
                            deals.Price = Convert.ToInt32(textBoxTotal.Text);
                            deals.SellerID = Convert.ToInt32(comboBoxSeller.SelectedItem.ToString().Split('.')[0]);
                            deals.Data = data;
                            deals.Type = 0;
                            Program.csdb.SaveChanges();
                            ShowDeals();
                        }
                    }
                    else
                    {
                        if (textBoxPayment.Text != "")
                        {
                            string data = comboBoxProvider.SelectedItem.ToString().Split('.')[0] + ":" + textBoxNumber.Text + ":" + textBoxPayment.Text;
                            Deals deals = listViewDeals.SelectedItems[0].Tag as Deals;
                            deals.Price = Convert.ToInt32(textBoxTotalP.Text);
                            deals.SellerID = Convert.ToInt32(comboBoxSeller.SelectedItem.ToString().Split('.')[0]);
                            deals.Data = data;
                            deals.Type = 1;
                            Program.csdb.SaveChanges();
                            ShowDeals();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите продавца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSeller.SelectedItem != null)
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (comboBoxPhone.SelectedItem != null)
                    {
                        string[] phData =
                        {
                        comboBoxPhone.SelectedIndex.ToString(),
                        textBoxColor.Text,
                        comboBoxSd.SelectedItem.ToString().Split('г')[0],
                        comboBoxCase.SelectedIndex.ToString(),
                        comboBoxSafe.SelectedIndex.ToString()
                    };
                        string data = string.Join(":", phData);
                        Deals deals = new Deals();
                        deals.Price = Convert.ToInt32(textBoxTotal.Text);
                        deals.SellerID = Convert.ToInt32(comboBoxSeller.SelectedItem.ToString().Split('.')[0]);
                        deals.Data = data;
                        deals.Type = 0;
                        Program.csdb.Deals.Add(deals);
                        Program.csdb.SaveChanges();
                        ShowDeals();
                    }
                }
                else
                {
                    if (textBoxPayment.Text != "")
                    {
                        string data = comboBoxProvider.SelectedItem.ToString().Split('.')[0] + ":" + textBoxNumber.Text + ":" + textBoxPayment.Text;
                        Deals deals = new Deals();
                        deals.Price = Convert.ToInt32(textBoxTotalP.Text);
                        deals.SellerID = Convert.ToInt32(comboBoxSeller.SelectedItem.ToString().Split('.')[0]);
                        deals.Data = data;
                        deals.Type = 1;
                        Program.csdb.Deals.Add(deals);
                        Program.csdb.SaveChanges();
                        ShowDeals();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите продавца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Fee()
        {
            if (textBoxPayment.Text != "" && comboBoxProvider.SelectedItem != null)
            {
                int price = Convert.ToInt32(textBoxPayment.Text);
                int fee = price * Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split(':')[1]) / 100;
                price += fee;
                textBoxFee.Text = fee.ToString();
                textBoxTotalP.Text = price.ToString();
            }
            else
            {
                textBoxFee.Text = "0";
                textBoxTotalP.Text = "0";
            }
        }
        void Total()
        {
            if (textBoxPrice.Text != "")
            {
                int total = Convert.ToInt32(textBoxPrice.Text);
                if (comboBoxSd.SelectedIndex != 0)
                {
                    total += Convert.ToInt32(comboBoxSd.SelectedItem.ToString().Split('+')[1].Split(')')[0]);
                }
                if (comboBoxCase.SelectedIndex != 0)
                {
                    total += Convert.ToInt32(comboBoxCase.SelectedItem.ToString().Split('+')[1].Split(')')[0]);
                }
                if (comboBoxSafe.SelectedIndex != 0)
                {
                    total += Convert.ToInt32(comboBoxSafe.SelectedItem.ToString().Split('+')[1].Split(')')[0]);
                }
                textBoxTotal.Text = total.ToString();
            }
        }
        private void listViewDeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDeals.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Deals deals = listViewDeals.SelectedItems[0].Tag as Deals;
                comboBoxSeller.SelectedIndex = comboBoxSeller.FindString(deals.SellerID.ToString());
                //Указываем, что может быть изменено
                if (deals.Type == 0)
                {
                    string[] data = deals.Data.Split(':');
                    comboBoxType.SelectedIndex = 0;
                    comboBoxPhone.SelectedIndex = comboBoxPhone.FindString(data[0]);
                    textBoxColor.Text = data[1];
                    comboBoxSd.SelectedIndex = comboBoxSd.FindString(data[2]);
                    comboBoxCase.SelectedIndex = Convert.ToInt32(data[3]);
                    comboBoxSafe.SelectedIndex = Convert.ToInt32(data[4]);
                    //textBoxPrice.Text = "0";
                    //textBoxTotal.Text = "0";
                } 
                else
                {
                    string[] data = deals.Data.Split(':');
                    comboBoxType.SelectedIndex = 1;
                    comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(data[0]);
                    textBoxNumber.Text = data[1];
                    textBoxPayment.Text = data[2];
                }
            }
            else
            {
                //Иначе очищаем поля для ввода
                comboBoxSd.SelectedIndex = 0;
                comboBoxSafe.SelectedIndex = 0;
                comboBoxCase.SelectedIndex = 0;
                comboBoxPhone.SelectedItem = null;
                textBoxPrice.Text = "0";
                textBoxTotal.Text = "0";
                textBoxColor.Text = "Чёрный";

                comboBoxProvider.SelectedItem = null;
                textBoxNumber.Text = "";
                textBoxPayment.Text = "";
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                labelPhone.Visible = true;
                comboBoxPhone.Visible = true;
                labelColor.Visible = true;
                textBoxColor.Visible = true;
                labelSd.Visible = true;
                comboBoxSd.Visible = true;
                labelCase.Visible = true;
                comboBoxCase.Visible = true;
                labelSafe.Visible = true;
                comboBoxSafe.Visible = true;
                labelPrice.Visible = true;
                textBoxPrice.Visible = true;
                labelTotal.Visible = true;
                textBoxTotal.Visible = true;

                labelProvider.Visible = false;
                comboBoxProvider.Visible = false;
                labelPayment.Visible = false;
                textBoxPayment.Visible = false;
                labelNumber.Visible = false;
                textBoxNumber.Visible = false;
                labelFee.Visible = false;
                textBoxFee.Visible = false;
                labelTotalP.Visible = false;
                textBoxTotalP.Visible = false;
            }
            else
            {
                labelPhone.Visible = false;
                comboBoxPhone.Visible = false;
                labelColor.Visible = false;
                textBoxColor.Visible = false;
                labelSd.Visible = false;
                comboBoxSd.Visible = false;
                labelCase.Visible = false;
                comboBoxCase.Visible = false;
                labelSafe.Visible = false;
                comboBoxSafe.Visible = false;
                labelPrice.Visible = false;
                textBoxPrice.Visible = false;
                labelTotal.Visible = false;
                textBoxTotal.Visible = false;

                labelProvider.Visible = true;
                comboBoxProvider.Visible = true;
                labelPayment.Visible = true;
                textBoxPayment.Visible = true;
                labelNumber.Visible = true;
                textBoxNumber.Visible = true;
                labelFee.Visible = true;
                textBoxFee.Visible = true;
                labelTotalP.Visible = true;
                textBoxTotalP.Visible = true;
            }
        }

        private void comboBoxPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPhone.SelectedItem != null)
            {
                foreach (Phones phones in Program.csdb.Phones)
                {
                    if (phones.Id == Convert.ToInt32(comboBoxPhone.SelectedItem.ToString().Split('.')[0]))
                    {
                        textBoxPrice.Text = phones.Price.ToString();
                        Total();
                        break;
                    }
                }
            }
        }

        private void comboBoxSafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void comboBoxCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void comboBoxSd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {
            Fee();
        }
    }
}
