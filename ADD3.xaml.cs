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
    /// Логика взаимодействия для ADD3.xaml
    /// </summary>
    public partial class ADD3 : Window
    {
        public ADD3()
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

            Группа_автомобилей p1 = new Группа_автомобилей();

            p1.Код_группы = Convert.ToInt32(tt1.Text);
            p1.Наименование_группы = Convert.ToString(tt2.Text);
            p1.Норма_амортизации = Convert.ToString(tt3.Text);

            try
            {
                db.Группа_автомобилей.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
