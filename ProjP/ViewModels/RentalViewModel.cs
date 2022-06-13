using ProjP.Commands;
using ProjP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjP.ViewModels
{
    public class RentalViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        RentalService ObjRentalService;
        public RentalViewModel()
        {
            ObjRentalService = new RentalService();
            LoadData();
            CurrentRental = new RentalDTO();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);

        }


        #region DisplayOperation
        private ObservableCollection<RentalDTO> rentalsList;

        public ObservableCollection<RentalDTO> RentalsList
        {
            get { return rentalsList; }
            set { rentalsList = value; OnPropertyChanged("RentalsList"); }
        }

        private void LoadData()
        {
            RentalsList = new ObservableCollection<RentalDTO>(ObjRentalService.GetAll());
        }

        #endregion


        private RentalDTO currentRental;
        public RentalDTO CurrentRental
        {
            get { return currentRental; }
            set { currentRental = value; OnPropertyChanged("CurrentRental"); }

        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                var IsSaved = ObjRentalService.Add(CurrentRental);
                LoadData();
                if (IsSaved) { 
                    MessageBox.Show("Dodano dane wypożyczenia", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

                Message = "Pracownik zapisany";
            }
                else
            {

                MessageBox.Show("Nie dodano danych wypożyczenia", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

                Message = "Pracownik nie zapisany błąd";
            }
        }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #region SearchOperation
        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }

        }
        public void Search()
        {
            try
            {
                var ObjRental = ObjRentalService.Search(CurrentRental.WypożyczenieId);
                if (ObjRental != null)
                {
                    CurrentRental.DataWypożyczenia = ObjRental.DataWypożyczenia;
                    CurrentRental.DataOddania = ObjRental.DataOddania;
                    CurrentRental.Cena = ObjRental.Cena;
                    CurrentRental.FakturaId=ObjRental.FakturaId;
                    CurrentRental.PracownikId = ObjRental.PracownikId;

                    MessageBox.Show("Wyszukano wypożyczenie", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Nie znaleźono wypożyczenia", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }


        #endregion

        #region UpdateOperation
        private RelayCommand updateCommand;


        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }
        public void Update()
        {
            try
            {
                var IsUpdated = ObjRentalService.Update(CurrentRental);
                LoadData();
                if (IsUpdated)
                {
                   
                    Message = "Employee Update";
                    MessageBox.Show("Uaktualniono dane wypożyczenia", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
                  
                }
                else
                {
                    MessageBox.Show("Nie uaktualniono danych wypożyczenia", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
                    Message = "Update Operation Failed";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion


        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDeleted = ObjRentalService.Delete(CurrentRental.WypożyczenieId);
                LoadData();
                if (IsDeleted)
                {
                    Message = "Pracownik usuniety";
                    
                   
                    MessageBox.Show("Usunięto dane wypożyczenia", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Nie usunięto danych wypożyczenia", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);
                    Message = "Błąd operacji";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}
