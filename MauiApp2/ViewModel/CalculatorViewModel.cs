using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;
using MauiApp2.View;

namespace MauiApp2.ViewModel
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        public string _digit = "0";
        
        public string DisplayLabel { get => _digit; set { _digit = value; OnPropertyChanged(); } }

        public CalculatorModel calculator = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand IsDigit => new Command<string>(NewDigit);

        public ICommand IsAction => new Command<string>(NewAction);

        public ICommand IsEq => new Command<string>(NewEq);

        public ICommand IsClear => new Command<string>(NewPage);

        private void NewDigit(string Digit)
        {
            if (DisplayLabel == "0")
                DisplayLabel = Digit;
            else
                DisplayLabel += Digit;

        }

        private void NewAction(string action)
        {
            DisplayLabel += "\n";
            calculator.ActionPressed(DisplayLabel, action);
        }

        private void NewEq(string eq)
        {
            DisplayLabel = calculator.EqAction(DisplayLabel);
        }

        private void NewPage(string page)
        {
            DisplayLabel = "0";
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
