using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXPopupNotUpdatingProperty.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _showDXPopup;

        [ObservableProperty]
        private bool _showLabel;

        public MainViewModel()
        {
            _showDXPopup = false;
            _showLabel = false;
        }

        [RelayCommand]
        public async Task DisplayDXPopup()
        {
            ShowDXPopup = true;
        }


        [RelayCommand]
        public async Task HideDXPopup()
        {
            ShowDXPopup = false;
        }

        [RelayCommand]
        public async Task ShowHideLabel()
        {
            ShowLabel = !ShowLabel;
        }
    }
}
