using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Generyki;

namespace Lab5B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Dictionary<int, Student> studenci = new Dictionary<int, Student>();

        public MainWindow()
        {
            InitializeComponent();
            studenci.Add(12345, new Student { Nazwisko = "Kowalski", Ocena = 4.5 });
            studenci.Add(23456, new Student { Nazwisko = "Nowak", Ocena = 5.0 });
            studenci.Add(34567, new Student { Nazwisko = "Wiśniewski", Ocena = 3.7 });
            studenci.Add(45678, new Student { Nazwisko = "Zieliński", Ocena = 4.2 });
        }


        private void BtnSzukaj_Click(object sender, RoutedEventArgs e)
        {
            /*
            int numerAlbumu;
            try
            {
                numerAlbumu = Convert.ToInt32(TxtBxNumer.Text);
                if (studenci.ContainsKey(numerAlbumu))
                {
                    var student = studenci[numerAlbumu];
                    MessageBox.Show($"Nazwisko: {student.Nazwisko}\nOcena: {student.Ocena}");
                }
                else
                {
                    MessageBox.Show("Nie znaleziono");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadz poprawny numer albumu");
            }
            */



            string pierwszyString = "Apple";
            string drugiString = "Banana";
            string wynikString = ZnajdzWiekszy.znajdzWiekszy(pierwszyString, drugiString);
            MessageBox.Show($"Wiekszy string: {wynikString}");
            double pierwszyDouble = 4.5;
            double drugiDouble = 3.8;
            double wynikDouble = ZnajdzWiekszy.znajdzWiekszy(pierwszyDouble, drugiDouble);
            MessageBox.Show($"Wieksza liczba: {wynikDouble}");
            Student pierwszyStudent = new Student { Nazwisko = "Kowalski", Ocena = 4.5 };
            Student drugiStudent = new Student { Nazwisko = "Nowak", Ocena = 5.0 };
            Student wynikStudent = ZnajdzWiekszy.znajdzWiekszy(pierwszyStudent, drugiStudent);
            MessageBox.Show($"Wiekszy student: {wynikStudent.Nazwisko}, Ocena: {wynikStudent.Ocena}");

        }

        private void BtnRegal_Click(object sender, RoutedEventArgs e)
        {
            var regałDouble = new Regał<double>();
            regałDouble.Półka1 = 3.14;
            regałDouble.WstawNaWolnąPółkę(2.71);
            regałDouble.WolnaPółka = 1.61;
            MessageBox.Show($"Regał z double:\n{regałDouble.ToString()}");
            var regałStudent = new Regał<Student>();
            regałStudent.Półka1 = new Student { Nazwisko = "Kowalski", Ocena = 4.5 };
            regałStudent.WstawNaWolnąPółkę(new Student { Nazwisko = "Nowak", Ocena = 5.0 });
            regałStudent.WolnaPółka = new Student { Nazwisko = "Wiśniewski", Ocena = 3.7 };
            MessageBox.Show($"Regał z Student:\n{regałStudent.ToString()}");
        }
    }
    }

    
