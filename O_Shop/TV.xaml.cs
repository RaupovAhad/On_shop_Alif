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
    /// Логика взаимодействия для TV.xaml
    /// </summary>
    public partial class TV : Window
    {
        public TV()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (PhoneTV.Text.Length > 0 || TovarTV.Text.Length > 0 ||
                PriceTV.Text.Length > 0 || SrokTV.Text.Length > 0)
            {
                if (SrokTV.Text == "3" || SrokTV.Text == "6" || SrokTV.Text == "9"
                    || SrokTV.Text == "12" || SrokTV.Text == "18" || SrokTV.Text == "24")
                {
                    try
                    {
                        short Sr = short.Parse(SrokTV.Text);
                        short Sum = short.Parse(PriceTV.Text);

                        short s = 100;
                        //short pr_3 = 3;
                        switch (Sr)
                        {
                            case 24:
                                LabSummTV.Content = Sum + (Sum * 5) / s;
                                break;
                            default:
                                LabSummTV.Content = Sum;
                                break;
                        }
                        MessageBox.Show("Товар: " + TovarTV.Text + " оформлен в рассрочку на " + SrokTV.Text + " месяцев, общая сумма покупки : " + LabSummTV.Content);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
