using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiUU.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class DatailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]

        async Task GoBack() {
            await Shell.Current.GoToAsync("..");
        }
    }
}
