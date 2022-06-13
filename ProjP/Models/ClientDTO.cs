using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class ClientDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private int klientid;
        public int KlientId
        {
            get { return klientid; }
            set { klientid = value; OnPropertyChanged("KlientId"); }
        }
        private string imię;
        public string Imię
        {
            get { return imię; }
            set { imię = value; OnPropertyChanged("Imię"); }
        }
        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; OnPropertyChanged("Nazwisko"); }
        }

        private string pesel;
        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; OnPropertyChanged("Pesel"); }
        }

        private string nrtelefon;
        public string NrTelefon
        { 
            get { return nrtelefon; }
            set { nrtelefon = value; OnPropertyChanged("NrTelefon"); }
        }


    }
}
