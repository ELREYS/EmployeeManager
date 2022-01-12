using EmployeeManager.Common.Model;
using System;
using System.ComponentModel;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private readonly Employee employee;

        public EmployeeViewModel(Employee employee)
        {
            this.employee = employee;
        }


        public string FirstName
        {
            get => employee.FirstName;
            set
            {
                if (employee.FirstName != value)
                {
                    employee.FirstName = value;
                    RaisePropertyChanged(nameof(FirstName));
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get => employee.EntryDate;
            set
            {
                if (employee.EntryDate != value)
                {
                    employee.EntryDate = value;
                    RaisePropertyChanged(nameof(EntryDate));
                }
            }
        }

        public int JobRoleId
        {
            get => employee.JobRoleId;
            set
            {
                if (employee.JobRoleId != value)
                {
                    employee.JobRoleId = value;
                    RaisePropertyChanged(nameof(JobRoleId));
                }
            }
        }

        public bool IsCoffeeDrinker
        {
            get => employee.IsCoffeeDrinker;
            set
            {
                if (employee.IsCoffeeDrinker != value)
                {
                    employee.IsCoffeeDrinker = value;
                    RaisePropertyChanged(nameof(IsCoffeeDrinker));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
