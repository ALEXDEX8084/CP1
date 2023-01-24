//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace XamlApp1
//{
//    public class IncreasePriceCommand : ICommand
//    {
//        public event EventHandler CanExecuteChanged;
//        PhoneViewModel viewModel;
//        public IncreasePriceCommand(PhoneViewModel vm)
//        {
//            viewModel = vm;
//        }

//        public bool CanExecute(object parameter)
//        {
//            return viewModel.Prize < 1000000000000000000;
//        }

//        public void Execute(object parameter)
//        {
//            if (CanExecute(parameter))
//                viewModel.IncreaseSalary();
//        }
//    }
//}