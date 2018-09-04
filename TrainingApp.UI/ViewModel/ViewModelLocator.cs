/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:TrainingApp.UI"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using TrainningApp.Services.Interface;
using TrainningApp.Repositories.Interface;
using TrainningApp.Repositories;
using TrainningApp.Services;

namespace TrainingApp.UI.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //Services
            SimpleIoc.Default.Register<ILoggInRepository, LoggInRepository>();
            SimpleIoc.Default.Register<IPasswordVerfierServices, PasswordVerifierServices>();
            SimpleIoc.Default.Register<IUserRepository, UserRepository>();
            SimpleIoc.Default.Register<IUserServices, UserServices>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoggingViewModel>();
            SimpleIoc.Default.Register<LoggInViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<ScheduleViewModel>();
            SimpleIoc.Default.Register<LoggInGoodViewModel>();
            SimpleIoc.Default.Register<AddUserViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public LoggingViewModel Logging
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoggingViewModel>();
            }
        }

        public LoggInViewModel LoggIn
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoggInViewModel>();
            }
        }

        public SettingsViewModel Settings
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SettingsViewModel>();
            }
        }

        public ScheduleViewModel Schedule
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ScheduleViewModel>();
            }
        }

        public LoggInGoodViewModel ShowOkeyMessage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoggInGoodViewModel>();
            }
        }

        public AddUserViewModel AddUserViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddUserViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}