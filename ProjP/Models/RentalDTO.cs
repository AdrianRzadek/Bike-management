using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class RentalDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private int wypożyczenieid;
        public int WypożyczenieId
        {
            get { return wypożyczenieid; }
            set { wypożyczenieid = value; OnPropertyChanged("WypożyczenieId"); }
        }
        private DateTime datawypożyczenia;
        public DateTime DataWypożyczenia
        {
            get { return datawypożyczenia; }
            set { datawypożyczenia = value; OnPropertyChanged("DataWypożyczenia"); }
        }
        private DateTime dataoddania;
        public DateTime DataOddania
        {
            get { return dataoddania; }
            set { dataoddania = value; OnPropertyChanged("DataOddania"); }
        }
        private decimal cena;
        public decimal Cena
        {
            get { return cena; }
            set { cena = value; OnPropertyChanged("Cena"); }
        }

        private int fakturaid;
        public int FakturaId
        {
            get { return fakturaid; }
            set { fakturaid = value; OnPropertyChanged("FakturaId"); }
        }

        private int pracownikid;
        public int PracownikId
        {
            get { return pracownikid; }
            set { pracownikid = value; OnPropertyChanged("PracownikId"); }
        }

    }
}
