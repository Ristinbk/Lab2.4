using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab4.Controllers
{
    public class NewGroupFormController : INotifyPropertyChanged
    {
        private int? _number;
        private Specialty? _codeSpecialty;
        public List<Specialty> Specialties { get; }

        public Specialty? CodeSpecialty
        {
            get => _codeSpecialty;
            set
            {
                _codeSpecialty = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public IGroup Group => CanSave ? new Group(new NumberGroup(CodeSpecialty.Value, DateTime.Now.Year))
       : null;

        public bool CanSave => CodeSpecialty.HasValue;

        public NewGroupFormController(string codeSpecialty)
        {
            Specialties = new List<Specialty>();
            foreach (var t in Enum.GetValues(typeof(Specialty)).Cast<Specialty>().ToList())
            {
                Specialties.Add(t);
            }
            _codeSpecialty = Specialties.Find(s=>s.Equals(codeSpecialty));
        }

    public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
