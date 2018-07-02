using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab2;

namespace Lab4.Controllers
{
    public class NewStudentFormController : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _patronomyc;
        private int? _year;
        private int? _month;
        private int? _day;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public string Patronomyc
        {
            get => _patronomyc;
            set
            {
                _patronomyc = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Year
        {
            get => _year;
            set
            {
                _year = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Month
        {
            get => _month;
            set
            {
                _month = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Day
        {
            get => _day;
            set
            {
                _day = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public IStudent Student => CanSave
            ? new Student(new FullName(FirstName, LastName, Patronomyc),
                new DateTime(Year.Value, Month.Value, Day.Value))
            : null;

        public bool CanSave =>
             !string.IsNullOrWhiteSpace(FirstName)
            && !string.IsNullOrWhiteSpace(LastName)
            && !string.IsNullOrWhiteSpace(Patronomyc)
            && Year.HasValue
            && Month.HasValue
            && Day.HasValue;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}