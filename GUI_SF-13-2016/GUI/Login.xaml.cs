using GUI_SF_13_2016.DAL;
using SF_13_2017.Model;
using SF_13_2017.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GUI_SF_13_2016.GUI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string korisnickoIme;
        string lozinka;

        Korisnik ulogovaniKorisnik = null;

        int brojPokusaja;

        public Login()
        {
            InitializeComponent();
            brojPokusaja = 0;
        }

        private void btPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            korisnickoIme = tbKorisnickoIme.Text;
            lozinka = tbLozinka.Text;

            foreach(Korisnik k in RadSaKorisnik.GetList())
            {
                if(k.KorisnickoIme == korisnickoIme && k.Lozinka == lozinka)
                {
                    //ULOGOVAN!!!
                    ulogovaniKorisnik = k;
                    break;
                }
            }

            if(ulogovaniKorisnik != null)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            else if (brojPokusaja >= 2)
            {
                MessageBox.Show("Promasili ste 3 puta!!!", "!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
            else
            {
                MessageBox.Show("Netacni podaci!!!", "!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                brojPokusaja++;
            }
        }
    }
}
