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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace proga2122
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        mydatabase1Entities db = mydatabase1Entities.GetContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.МОЛ.Load();
            grid1.ItemsSource = db.МОЛ.Local.ToBindingList();
        }

        private void Window_Loaded2(object sender, RoutedEventArgs e)
        {
            db.Месячные_пробеги.Load();
            grid2.ItemsSource = db.Месячные_пробеги.Local.ToBindingList();
        }

        private void Window_Loaded3(object sender, RoutedEventArgs e)
        {
            db.Группа_автомобилей.Load();
            grid3.ItemsSource = db.Группа_автомобилей.Local.ToBindingList();
        }

        private void Window_Loaded4(object sender, RoutedEventArgs e)
        {
            db.Автомобили.Load();
            grid4.ItemsSource = db.Автомобили.Local.ToBindingList();
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            ADD1 f = new ADD1();
            f.ShowDialog();
            grid1.Focus();

            db.МОЛ.Load();
            grid1.ItemsSource = db.МОЛ.ToList();
            grid1.ItemsSource = db.МОЛ.Local.ToBindingList();
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid1.SelectedIndex;
            if (indexRow != -1)
            {
                МОЛ row = (МОЛ)grid1.Items[indexRow];

                Class1.Табельный_номер = row.Табельный_номер;
                Class1.ФИО = row.ФИО;
                Class1.телефон = row.телефон;

                EDIT1 f = new EDIT1();
                f.ShowDialog();

                grid1.Items.Refresh();
                grid1.Focus();
            }
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    МОЛ row = (МОЛ)grid1.SelectedItems[0];

                    db.МОЛ.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }






        private void b1_Click(object sender, RoutedEventArgs e)
        {
            ADD2 f = new ADD2();
            f.ShowDialog();
            grid2.Focus();

            db.Месячные_пробеги.Load();
            grid2.ItemsSource = db.Месячные_пробеги.ToList();
            grid2.ItemsSource = db.Месячные_пробеги.Local.ToBindingList();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid2.SelectedIndex;
            if (indexRow != -1)
            {
                Месячные_пробеги row = (Месячные_пробеги)grid2.Items[indexRow];

                Class2.Государственный_номер = row.Государственный_номер;
                Class2.Пробег = row.Пробег;
                Class2.Номер_месяца = row.Номер_месяца;

                EDIT2 f = new EDIT2();
                f.ShowDialog();

                grid2.Items.Refresh();
                grid2.Focus();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Месячные_пробеги row = (Месячные_пробеги)grid2.SelectedItems[0];

                    db.Месячные_пробеги.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }







        private void c1_Click(object sender, RoutedEventArgs e)
        {
            ADD3 f = new ADD3();
            f.ShowDialog();
            grid3.Focus();

            db.Группа_автомобилей.Load();
            grid3.ItemsSource = db.Группа_автомобилей.ToList();
            grid3.ItemsSource = db.Группа_автомобилей.Local.ToBindingList();
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid3.SelectedIndex;
            if (indexRow != -1)
            {
                Группа_автомобилей row = (Группа_автомобилей)grid3.Items[indexRow];

                Class3.Код_группы = row.Код_группы;
                Class3.Наименование_группы = row.Наименование_группы;
                Class3.Норма_амортизации = row.Норма_амортизации;


                EDIT3 f = new EDIT3();
                f.ShowDialog();

                grid3.Items.Refresh();
                grid3.Focus();
            }
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Группа_автомобилей row = (Группа_автомобилей)grid3.SelectedItems[0];

                    db.Группа_автомобилей.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }






        private void d1_Click(object sender, RoutedEventArgs e)
        {
            ADD4 f = new ADD4();
            f.ShowDialog();
            grid4.Focus();

            db.Автомобили.Load();
            grid4.ItemsSource = db.Автомобили.ToList();
            grid4.ItemsSource = db.Автомобили.Local.ToBindingList();
        }

        private void d2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid4.SelectedIndex;
            if (indexRow != -1)
            {
                Автомобили row = (Автомобили)grid4.Items[indexRow];

                Class4.Государственный_номер = row.Государственный_номер;
                Class4.Марка_автомобиля = row.Марка_автомобиля;
                Class4.Код_группы = row.Код_группы;
                Class4.Первоначальная_стоимость = row.Первоначальная_стоимость;
                Class4.Дата_ввода_в_эксплуатацию = row.Дата_ввода_в_эксплуатацию;
                Class4.Пробег_на_начало_года = row.Пробег_на_начало_года;
                Class4.Стоимость_автомобиля_на_начало_года = row.Стоимость_автомобиля_на_начало_года;
                Class4.Табельный_номер_материально_ответственного_лица = row.Табельный_номер_материально_ответственного_лица;

                EDIT4 f = new EDIT4();
                f.ShowDialog();

                grid4.Items.Refresh();
                grid4.Focus();
            }
        }

        private void d3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Автомобили row = (Автомобили)grid4.SelectedItems[0];

                    db.Автомобили.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }
    }
}
