using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProjP.Models;
using ProjP.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace ProjP.ViewModels
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        
       

            #region INotifyPropertyChanged_Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            #endregion


            ClientService ObjClientService;
            public ClientViewModel()
            {
                ObjClientService = new ClientService();
                LoadData();
                CurrentClient = new ClientDTO();
                saveCommand = new RelayCommand(Save);
                searchCommand = new RelayCommand(Search);
                updateCommand = new RelayCommand(Update);
                deleteCommand = new RelayCommand(Delete);

            }


            #region DisplayOperation
            private ObservableCollection<ClientDTO> clientsList;

            public ObservableCollection<ClientDTO> ClientsList
            {
                get { return clientsList; }
                set { clientsList = value; OnPropertyChanged("ClientsList"); }
            }

            private void LoadData()
            {
               ClientsList = new ObservableCollection<ClientDTO>(ObjClientService.GetAll());
            }

            #endregion


            private ClientDTO currentClient;
            public ClientDTO CurrentClient
            {
                get { return currentClient; }
                set { currentClient = value; OnPropertyChanged("CurrentClient"); }

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
                var IsSaved = ObjClientService.Add(CurrentClient);
                LoadData();
                if (IsSaved)
                {
                    MessageBox.Show("Dodano dane klienta", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

                    Message = "Pracownik zapisany";
                }
                else
                {

                    MessageBox.Show("Nie dodano danych klienta", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

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
                    var ObjClient = ObjClientService.Search(CurrentClient.KlientId);
                    if (ObjClient != null)
                    {
                    CurrentClient.Pesel = ObjClient.Pesel;
                    CurrentClient.Nazwisko = ObjClient.Nazwisko;
                    CurrentClient.Imię = ObjClient.Imię;
                    CurrentClient.NrTelefon = ObjClient.NrTelefon;

                    MessageBox.Show("Wyszukano klienta", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Nie znaleźono klienta", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);
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
                    var IsUpdated = ObjClientService.Update(CurrentClient);
                LoadData();
                if (IsUpdated)
                    {
                    Message = "Employee Update";
                    MessageBox.Show("Uaktualniono dane klienta", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
                   
                }
                else
                {
                    MessageBox.Show("Nie uaktualniono danych klienta", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
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
                    var IsDeleted = ObjClientService.Delete(CurrentClient.KlientId);
                LoadData();
                if (IsDeleted)
                    {

                    Message = "Pracownik usuniety";
                    MessageBox.Show("Usunięto dane klienta", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
                else
                {
                    MessageBox.Show("Nie usunięto danych klienta", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);
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
