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
    /// Логика взаимодействия для ADD4.xaml
    /// </summary>
    public partial class ADD4 : Window
    {
        public ADD4()
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

            if (tt3_Copy2.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy3.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy4.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy1.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            Автомобили p1 = new Автомобили();

            p1.Государственный_номер = Convert.ToInt32(tt1.Text);
            p1.Марка_автомобиля = Convert.ToString(tt2.Text);
            p1.Код_группы = Convert.ToInt32(tt3.Text);
            p1.Первоначальная_стоимость = Convert.ToInt32(tt3_Copy2.Text);
            p1.Дата_ввода_в_эксплуатацию = Convert.ToDateTime(tt3_Copy3.Text);
            p1.Пробег_на_начало_года = Convert.ToString(tt3_Copy4.Text);
            p1.Стоимость_автомобиля_на_начало_года = Convert.ToInt32(tt3_Copy1.Text);
            p1.Табельный_номер_материально_ответственного_лица = Convert.ToString(tt3_Copy.Text);

            try
            {
                db.Автомобили.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
