﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab4.Controllers
{
    public class NewTeacherFormController : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _patronymic;
        private int? _year;
        private int? _month;
        private int? _day;
        private Title _title;

        public ITeacher Teacher=> CanSave
            ? new Teacher(new FullName(FirstName, LastName, Patronymic),
                new DateTime(Year.Value, Month.Value, Day.Value), Title)
            : null;

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

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
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

        public Title Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public bool CanSave =>
            !string.IsNullOrWhiteSpace(FirstName)
            && !string.IsNullOrWhiteSpace(LastName)
            && !string.IsNullOrWhiteSpace(Patronymic)
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
