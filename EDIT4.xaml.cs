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
    /// Логика взаимодействия для EDIT4.xaml
    /// </summary>
    public partial class EDIT4 : Window
    {
        public EDIT4()
        {
            InitializeComponent();
        }

        mydatabase1Entities db = mydatabase1Entities.GetContext();

        Автомобили p1;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.Автомобили.Where(p => p.Государственный_номер == Class4.Государственный_номер).FirstOrDefault();

            tt1.Text = Convert.ToString(p1.Государственный_номер);
            tt2.Text = Convert.ToString(p1.Марка_автомобиля);
            tt3.Text = Convert.ToString(p1.Код_группы);
            tt3.Text = Convert.ToString(p1.Первоначальная_стоимость);
            tt3.Text = Convert.ToString(p1.Дата_ввода_в_эксплуатацию);
            tt3.Text = Convert.ToString(p1.Пробег_на_начало_года);
            tt3.Text = Convert.ToString(p1.Стоимость_автомобиля_на_начало_года);
            tt3.Text = Convert.ToString(p1.Табельный_номер_материально_ответственного_лица);

        }

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
