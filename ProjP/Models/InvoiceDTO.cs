using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class InvoiceDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private int fakturaid;
        public int FakturaId
        {
            get { return fakturaid; }
            set { fakturaid = value; OnPropertyChanged("FakturaId"); }
        }
        private char nip;
        public char NIP
        {
            get { return nip; }
            set { nip = value; OnPropertyChanged("NIP"); }
        }
        private string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; OnPropertyChanged("Nazwa"); }
        }

        private DateTime datawystawienia;
        public DateTime DataWystawienia
        {
            get { return datawystawienia; }
            set { datawystawienia = value; OnPropertyChanged("DataWystawienia"); }
        }


    }
}
