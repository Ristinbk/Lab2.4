using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Controllers
{
    public class NewSubjectFormController
    {
        private string _subjectName;
        private SubjectType? _subjectType;
        public List<SubjectType>  SubjectTypes { get; }

        public string SubjectName
        {
            get => _subjectName;
            set
            {
                _subjectName = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public SubjectType? SubjectType
        {
            get => _subjectType;
            set
            {
                _subjectType = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public ISubject Subject => CanSave
            ? new Subject(SubjectName, SubjectType.Value)
            : null;

        public bool CanSave =>
             !string.IsNullOrWhiteSpace(SubjectName)
            && SubjectType.HasValue;



        public NewSubjectFormController(string subjectType)
        {
            SubjectTypes = new List<SubjectType>();
            foreach (var t in Enum.GetValues(typeof(SubjectType)).Cast<SubjectType>().ToList())
            {
                SubjectTypes.Add(t);
            }
            _subjectType = SubjectTypes.Find(s => s.Equals(subjectType));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
