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

namespace proga2122
{
    /// <summary>
    /// Логика взаимодействия для ADD2.xaml
    /// </summary>
    public partial class ADD2 : Window
    {
        public ADD2()
        {
            InitializeComponent();
        }

        mydatabase1Entities db = mydatabase1Entities.GetContext();

        private void bb11_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (tt1.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt2.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            Месячные_пробеги p1 = new Месячные_пробеги();

            p1.Государственный_номер = Convert.ToInt32(tt1.Text);
            p1.Пробег = Convert.ToString(tt2.Text);
            p1.Номер_месяца = Convert.ToInt32(tt3.Text);

            try
            {
                db.Месячные_пробеги.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
