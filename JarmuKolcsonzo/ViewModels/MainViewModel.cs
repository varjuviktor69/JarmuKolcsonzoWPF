using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _selectedViewModel;

        public ObservableObject SelectedViewModel
        {
            get { return _selectedViewModel; }
            // Értesíti a view rész, hogy változás történt az objektumban
            set { SetProperty(ref _selectedViewModel, value); }
        }
        
        // Frissíti a ContentControllban a megjelenítendő ablakot
        public RelayCommand<string> UpdateViewCommand { get; set; }

        private void UpdateView(string windowName)
        {
            if (windowName == "jármű")
            {
                SelectedViewModel = new JarmuViewModel();
            }
            else
            {
                SelectedViewModel = new UgyfelViewModel();                   
            }
        }

        private ObservableObject JarmuViewModel()
        {
            throw new NotImplementedException();
        }

        public MainViewModel()
        {
            UpdateViewCommand = new RelayCommand<string>(e => UpdateView(e));
        }
    }
}
