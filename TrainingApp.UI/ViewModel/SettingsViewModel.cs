using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using TrainningApp.Model.Model;
using TrainningApp.Repositories.Interface;
using TrainningApp.Services.Interface;

namespace TrainingApp.UI.ViewModel
{
    public class SettingsViewModel:ViewModelBase
    {
        #region Properties
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged("Username");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged("Password");
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                RaisePropertyChanged("Surname");
            }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                RaisePropertyChanged("Age");
            }
        }

        private string _weight;
        public string Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                RaisePropertyChanged("Weight");
            }
        }

        private string _height;
        public string Height
        {
            get { return _height; }
            set
            {
                _height = value;
                RaisePropertyChanged("Weight");
            }
        }

        private int _IMC;
        public int IMC
        {
            get { return _IMC; }
            set
            {
                _IMC = value;
                RaisePropertyChanged("IMC");
            }
        }

        #endregion

        #region Interfaces

        private readonly IUserServices _userServices;
        private readonly IUserRepository _userRepository;

        #endregion

        #region Commands

        private readonly RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get { return _saveCommand; }
        }
        #endregion

        public SettingsViewModel(IUserServices userService, IUserRepository userRepository)
        {
            //Interfaces
            _userServices = userService;
            _userRepository = userRepository;
            OnLoad();

            _saveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            var actualName = _userRepository.GetActualUserNickName();
            double IMCToPass;
            IMCToPass = _userServices.GetIMCByUserParameters(Weight, Height);
            IMC = (int)IMCToPass;
            _userRepository.ModifyUserByUsername(Name, Surname, Age, Weight, Height, Password, Username, IMC.ToString(),actualName);

        }

        private void OnLoad()
        {
            var name = _userRepository.GetActualUserNickName();
            var password = _userRepository.GetActualUserPassword();

            var user = _userRepository.GetUserByUserName(name, password);

            Name = user.Name;
            Username = user.UserNickname;
            Password = user.Password;
            Surname = user.Surname;
            Height = user.Height.ToString();
            Weight = user.Weight.ToString();
            IMC = user.IMC;
            Age = user.Age.ToString();

        }

    }
}
