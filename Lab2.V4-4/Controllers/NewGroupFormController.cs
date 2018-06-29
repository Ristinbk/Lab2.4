using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Lab4.Controllers
{
    public class NewGroupFormController : INotifyPropertyChanged
    {
        private int? _number;
        private Specialty? _codeSpecialty;

        public Specialty? CodeSpecialty
        {
            get => _codeSpecialty;
            set
            {
                _codeSpecialty = value;
                OnPropertyChanged(nameof(GetCanSave));
            }
        }

        public int? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(GetCanSave));
            }

        }
        public List<IGroup> Groups { get; }

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public IGroup Group => GetCanSave()
            ? new Group(new NumberGroup(CodeSpecialty.Value, Number.Value))
            : null;

        public bool GetCanSave() =>
            !string.IsNullOrWhiteSpace(CodeSpecialty.ToString())
            && Number.HasValue;

        public NewGroupFormController(List<IGroup> groups)
        {
            Groups = new List<IGroup>();
            foreach (var t in Enum.GetValues(typeof(Specialty)).Cast<Specialty>().ToList())
            {
                if (groups.All(d => d.NumberGroup.CodeSpecialty != t.ToString()))
                {
                    Groups.Add(new Group(new NumberGroup(t, DateTime.Now.Year)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
