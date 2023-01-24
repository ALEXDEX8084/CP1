using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;


namespace XamlApp1
{
    public class EmployeeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Employee employee;
        public ICommand Increase { get; set; }
        public ICommand IncreaseSalary11 { get; set; }
        public ICommand IncreaseSalary112 { get; set; }
        public ICommand IncreaseExp11 { get; set; }
        public ICommand IncreaseExp112 { get; set; }
        public ICommand IncreaseFactor11 { get; set; }
        public ICommand IncreaseFactor112 { get; set; }


        public EmployeeModel()
        {
            employee = new Employee();
            Increase = new Command(PrizeCount);
            IncreaseSalary11 = new Command(IncreaseSalary);
            IncreaseSalary112 = new Command(IncreaseSalary1);
            IncreaseExp11 = new Command(IncreaseExp);
            IncreaseExp112 = new Command(IncreaseExp1);
            IncreaseFactor11 = new Command(IncreaseFactor);
            IncreaseFactor112 = new Command(IncreaseFactor1);
        }


        public void IncreaseSalary()
        {
            if (employee != null)
                Salary += 100;
        }
        public void IncreaseExp()
        {
            if (employee != null)
                Exp += 1;
        }
        public void IncreaseFactor()
        {
            if (employee != null)
                Factor += 0.1;
        }

        public void IncreaseSalary1()
        {
            if (employee != null)
                Salary -= 100;
        }
        public void IncreaseExp1()
        {
            if (employee != null)
                Exp -= 1;
        }
        public void IncreaseFactor1()
        {
            if (employee != null)
                Factor -= 0.1;
        }
        public void PrizeCount()
        {
            if (employee != null)
                Prize = Salary*Exp*Factor;
        }
        public string FIO
        {
            get { return employee.FIO; }
            set
            {
                if (employee.FIO != value)
                {
                    employee.FIO = value;
                    OnPropertyChanged("FIO");
                }
            }
        }
        public string Stuff
        {
            get { return employee.Stuff; }
            set
            {
                if (employee.Stuff != value)
                {
                    employee.Stuff = value;
                    OnPropertyChanged("Stuff");
                }
            }
        }
        public int Salary
        {
            get { return employee.Salary; }
            set
            {
                if (employee.Salary != value)
                {
                    employee.Salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }
        public int Exp
        {
            get { return employee.Exp; }
            set
            {
                if (employee.Exp != value)
                {
                    employee.Exp = value;
                    OnPropertyChanged("Exp");
                }
            }
        }
        public double Factor
        {
            get { return employee.Factor; }
            set
            {
                if (employee.Factor != value)
                {
                    employee.Factor = value;
                    OnPropertyChanged("Factor");
                }
            }
        }
        public double Prize
        {
            get { return employee.Prize; }
            set
            {
                if (employee.Prize != value)
                {
                    employee.Prize = value;
                    OnPropertyChanged("Prize");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}