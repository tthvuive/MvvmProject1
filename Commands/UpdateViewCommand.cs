using MvvmProject1.ViewModels;
using System;
using System.Windows.Input;

namespace MvvmProject1.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            if (parameter.ToString() == "Converter")
            {
                viewModel.SelectViewModel = new ConverterViewModel();
            }
            else if (parameter.ToString() == "Calculate")
            {
                viewModel.SelectViewModel = new MainCalculatorViewModel();
            }
        }
    }
}
