using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCliente
{
    public class Prenotazione
    {
        private const double PREZZO = 24.99;
        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public string Ora { get; private set; }

        public Prenotazione(Cliente cliente, DateTime data, string ora)
        {
            Cliente = cliente;
            cliente.Prenotazioni.Add(this);
            Data = data;
            Ora = ora;
        }
        private double CostoPrenotazione()
        {
            double costo = PREZZO;
            if ((Cliente.GetSesso() == "M" && this.Ora == "17:00") || Cliente.GetSesso() == "F")
            {
                costo = costo - (costo * 10) / 100;
            }
            return costo;
        }
        public string Stampa()
        {
            return ($"{Cliente.Stampa()} {Ora} {CostoPrenotazione()}€");
        }
    }
}
