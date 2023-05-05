using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace O_Shop
{
    /// <summary>
    /// Логика взаимодействия для Smart.xaml
    /// </summary>
    public partial class Smart : Window
    {
        public Smart()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Phone.Text.Length > 0 || Tovar.Text.Length > 0 ||
                Price.Text.Length > 0 || Srok.Text.Length > 0)
            {
                if (Srok.Text == "3" || Srok.Text == "6" || Srok.Text == "9"
                    || Srok.Text == "12" || Srok.Text == "18" || Srok.Text == "24")
                {
                    try
                    {
                        short Sr = short.Parse(Srok.Text);
                        short Sum = short.Parse(Price.Text);

                        short s = 100;
                        short pr_3 = 3;
                        switch (Sr)
                        {
                            case 12:
                                LabSumm.Content = Sum + (Sum * pr_3) / s;
                                break;
                            case 18:
                                LabSumm.Content = Sum + (Sum * 6) / s;
                                break;
                            case 24:
                                LabSumm.Content = Sum + (Sum * 9) / s;
                                break;
                            default:
                                LabSumm.Content = Sum;
                                break;
                        }
                        MessageBox.Show("Товар: " + Tovar.Text + " оформлен в рассрочку на " + Srok.Text + " месяцев, общая сумма покупки : " + LabSumm.Content);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Проверьте данные на корректность");
                    }
                }
                else
                    MessageBox.Show("Доступный срок рассрочки в месяцах (3,6,9,12,18,24)");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
