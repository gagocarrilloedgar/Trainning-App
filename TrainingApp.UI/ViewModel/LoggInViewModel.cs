using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using TrainningApp.Repositories.Interface;
using TrainningApp.Services.Interface;
using TrainingApp.UI.Views;
using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Windows.Input;
using TrainingApp.UI.MVVMFramework;

namespace TrainingApp.UI.ViewModel
{
    public class LoggInViewModel : ViewModelBase2
    {
        #region Properties

        private LoggInGoodViewModel _loggInGoodViewModel;
        public string passwordToPass;
        #region View bindings
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        private string _password2;
        public string Password2
        {
            get { return _password2; }
            set
            {
                _password2 = value;
                OnPropertyChanged("Password2");
            }
        }
        #endregion

        #region Interfaces
        private readonly ILoggInRepository _loggInRepository;
        private readonly IPasswordVerfierServices _passwordVerfifierServices;
        private readonly IUserRepository _userRepository;
        #endregion

        #endregion

        #region Commands
        public ICommand SuccesfullLoggInCommand
        {
            get;
            private set;
        }

        private readonly RelayCommand _viewUsers;

        public RelayCommand ViewUsers
        {
            get
            {
                return _viewUsers;
            }
        }


        #endregion

        public LoggInViewModel(IPasswordVerfierServices passwordVerifierServices, ILoggInRepository loggInRepository, IUserRepository userRepository)
        {
            #region Properties Initialization

            _loggInRepository = loggInRepository;
            _passwordVerfifierServices = passwordVerifierServices;
            _loggInGoodViewModel = new LoggInGoodViewModel();
            _userRepository = userRepository;
            #endregion

            #region RelayCommands
            SuccesfullLoggInCommand = new RelayCommand2(LogInSecure);
            _viewUsers = new RelayCommand(ViewUsersList);
            #endregion

        }

        private void LoggInSucced(ref bool success)
        {
            var actualname = Username;
            var actualpassword = Password;

            if (_loggInRepository.IsTheUsernameAvailable(actualname) == true)
            {
                success = _loggInRepository.LoggInUser(actualname, actualpassword);
            }
            else
            {
                success = false;
            }


        }

        private void ShowLoggInMessage()
        {
            bool success = false;
            var Message = "";

            LoggInSucced(ref success);

            if (success == true)
            {
                Message = "LoggIn was succesfull!";
                ShowDialog(Message);
            }
            else if (success == false )
            {
                Message = "Unable to connect to the Database! Invalid User";
                ShowDialog(Message);
            }
            else
            {
                Message = "Something went wrong, try again";
                ShowDialog(Message);

            }

        }

        private void ViewUsersList()
        {

            //var logginViewModel = new LoggingViewModel();
            //logginViewModel.DataContext = new AddUserView();

            var view = new MainWindow();
            view.myDataGrid.ItemsSource = _userRepository.GetUsers();
            view.Show();

        }

        private void ShowDialog(string Message)
        {
            var view = new LoggInGoodView();
            view.DataContext = _loggInGoodViewModel;
            _loggInGoodViewModel.Message = Message;
            view.Show();
        }

        private void LogInSecure(object parameter)
        {
            var passwordContainer = parameter as IPasswordService;
            if (passwordContainer != null)
            {
                var secureString = passwordContainer.GetPassword;
                passwordToPass = ConvertToNormalString(secureString);
            }
            else
            {
                ShowLoggInMessage();
                passwordToPass = "sfa";
                Password = passwordToPass;
            }

        }

        private string ConvertToNormalString(SecureString securePassword)
        {
            if (securePassword == null)
            {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }

}
