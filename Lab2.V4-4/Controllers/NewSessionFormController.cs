using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab2;
using Lab4.View;

namespace Lab4.Controllers
{
    public class NewSessionFormController : INotifyPropertyChanged
    {
        private int? _year;
        private SessionType? _sessionType;
        public List<ISession> Sessions { get; }

        public SessionType? SessionType
        {
            get => _sessionType;
            set
            {
                _sessionType = value;
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

        public ISession Session => CanSave
            ? new Session(SessionType.Value, Year.Value)
            : null;

        public bool CanSave =>
            !string.IsNullOrWhiteSpace(SessionType.ToString())
            && Year.HasValue;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
