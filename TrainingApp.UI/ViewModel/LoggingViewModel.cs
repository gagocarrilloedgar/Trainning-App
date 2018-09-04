using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using TrainingApp.UI.Views;
using TrainningApp.Repositories.Interface;

namespace TrainingApp.UI.ViewModel
{
    public class LoggingViewModel : ViewModelBase
    {
        #region Properties
        private FrameworkElement _dataContext;

        public FrameworkElement DataContext
        {
            get { return _dataContext; }
            set
            {
                _dataContext = value;
                RaisePropertyChanged("DataContext");
            }
        }

        #endregion
        #region Command

        //Common Commands
        private readonly RelayCommand _loggInCommand;
        public RelayCommand LoggInCommand
        {
            get
            {
                return _loggInCommand;
            }
        }

        private readonly RelayCommand _loggOutCommand;
        public RelayCommand LoggOutCommand
        {
            get
            {
                return _loggOutCommand;
            }
        }

        private readonly RelayCommand _addWorkoutCommand;
        public RelayCommand AddWorkoutCommand
        {
            get
            {
                return _addWorkoutCommand;
            }
        }

        private readonly RelayCommand _addFoodCommand;
        public RelayCommand AddFoodCommand
        {
            get
            {
                return _addFoodCommand;
            }
        }

        private readonly RelayCommand _addDietCommand;
        public RelayCommand AddDietCommand
        {
            get
            {
                return _addFoodCommand;
            }
        }

        private readonly RelayCommand _settingsCommand;
        public RelayCommand SettingsCommand
        {
            get
            {
                return _settingsCommand;
            }
        }

        private readonly RelayCommand _viewSchedule;
        public RelayCommand ViewSchedule
        {
            get
            {
                return _viewSchedule;
            }
        }

        private readonly RelayCommand _newUserCommand;
        public RelayCommand NewUserCommand
        {
            get { return _newUserCommand; }
        }

        //Custom Commands
        #endregion
        #region Interfaces 
        private readonly ILoggInRepository _loggInRepository;
        #endregion


        public LoggingViewModel(ILoggInRepository loggInRepository)
        {
            #region RelayCommands
            _loggInCommand = new RelayCommand(LoggIn);
            _addWorkoutCommand = new RelayCommand(AddWorkoutWiew);
            _addFoodCommand = new RelayCommand(AddWorkout);
            _addDietCommand = new RelayCommand(AddDiet);
            _settingsCommand = new RelayCommand(AddSettings);
            _viewSchedule = new RelayCommand(Schedule);
            _newUserCommand = new RelayCommand(AddUser);
            _loggOutCommand = new RelayCommand(LoggOut);
            #endregion

            _loggInRepository = loggInRepository;
        }

        private void LoggOut()
        {
            _loggInRepository.PurgeUser();
        }

        private void AddUser()
        {
            var view = new AddUserView();
            DataContext = view;
        }

        private void Schedule()
        {
            var newForm = new ScheduleView();
            newForm.Show();

        }

        private void AddSettings()
        {
            DataContext = new SettingsView();

        }

        private void AddDiet()
        {
            throw new NotImplementedException();
        }

        private void AddWorkout()
        {
            throw new NotImplementedException();
        }

        private void AddWorkoutWiew()
        {

        }

        private void LoggIn()
        {
            var window = new LoggInView();
            window.Show();
        }
    }
}
