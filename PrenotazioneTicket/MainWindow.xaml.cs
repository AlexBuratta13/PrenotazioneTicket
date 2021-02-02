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
using LibraryCliente;

namespace PrenotazioneTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAggiungiCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome;
                string cognome;

                if (txt_Nome.Text != "")
                {
                    nome = txt_Nome.Text;
                }
                else throw new Exception("Inserisci un nome!");

                if (txt_Cognome.Text != "")
                {
                    cognome = txt_Cognome.Text;
                }
                else throw new Exception("Inserisci un cognome!");

                Cliente cliente = new Cliente(nome, cognome);

                cliente.SetCellulare(txt_Cellulare.Text);
                if (btnM.IsChecked == true)
                {
                    cliente.SetSesso(true);
                }
                else
                {
                    cliente.SetSesso(false);
                }

                cmbClienti.Items.Add(cliente.Stampa());
                cmbClienti1.Items.Add(cliente.Stampa());

                txt_Nome.Clear();
                txt_Cognome.Clear();
                txt_Cellulare.Clear();
                btnM.IsChecked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
