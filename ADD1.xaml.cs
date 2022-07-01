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
    /// Логика взаимодействия для ADD1.xaml
    /// </summary>
    public partial class ADD1 : Window
    {
        public ADD1()
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

            МОЛ p1 = new МОЛ();

            p1.Табельный_номер = Convert.ToInt32(tt1.Text);
            p1.ФИО = Convert.ToString(tt2.Text);
            p1.телефон = Convert.ToInt32(tt3.Text);

            try
            {
                db.МОЛ.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
