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
    /// Логика взаимодействия для Komp.xaml
    /// </summary>
    public partial class Komp : Window
    {
        public Komp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PhoneKp.Text.Length > 0 || TovarKp.Text.Length > 0 ||
                PriceKp.Text.Length > 0 || SrokKp.Text.Length > 0)
            {
                if (SrokKp.Text == "3" || SrokKp.Text == "6" || SrokKp.Text == "9"
                    || SrokKp.Text == "12" || SrokKp.Text == "18" || SrokKp.Text == "24")
                {
                    try
                    {
                        short Sr = short.Parse(SrokKp.Text);
                        short Sum = short.Parse(PriceKp.Text);

                        short s = 100;
                        //short pr_3 = 3;
                        switch (Sr)
                        {
                            case 18:
                                LabSummKp.Content = Sum + (Sum * 4) / s;
                                break;
                            case 24:
                                LabSummKp.Content = Sum + (Sum * 8) / s;
                                break;
                            default:
                                LabSummKp.Content = Sum;
                                break;
                        }
                        MessageBox.Show("Товар: " + TovarKp.Text + " оформлен в рассрочку на " + SrokKp.Text + " месяцев, общая сумма покупки : " + LabSummKp.Content);
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
