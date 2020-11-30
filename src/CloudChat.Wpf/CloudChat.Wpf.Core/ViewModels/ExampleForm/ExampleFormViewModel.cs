using CloudChat.Wpf.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace CloudChat.Wpf.Core.ViewModels
{
    public class ExampleFormViewModel : MvxViewModel
    {
        private MvxObservableCollection<Person> _list = new MvxObservableCollection<Person>();
        private string _firstName;
        private string _lastName;

        public MvxObservableCollection<Person> List
        {
            get => _list;
            set
            {
                SetProperty(ref _list, value);
            }
        }

        public string FirstName
        {
            get => _firstName;
            set 
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(nameof(CanAddPerson));
            }
        }

        public string LastName
        {
            get =>_lastName;
            set 
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(nameof(CanAddPerson));
            }
        }

        public bool CanAddPerson => FirstName?.Length > 0 && LastName?.Length > 0;

        public IMvxCommand AddPersonCommand { get; set; }

        public ExampleFormViewModel()
        {
            AddPersonCommand = new MvxCommand(AddPerson);
        }

        public void AddPerson()
        {
            var person = new Person
            {
                FirstName = _firstName,
                LastName = _lastName
            };

            FirstName = null;
            LastName = null;

            _list.Add(person);
        }
    }
}
