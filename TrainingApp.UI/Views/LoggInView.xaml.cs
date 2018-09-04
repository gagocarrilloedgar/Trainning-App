using System;
using System.Security;
using System.Windows;
using TrainingApp.UI.ViewModel;
using TrainningApp.Repositories.Interface;
using TrainningApp.Services.Interface;

namespace TrainingApp.UI.Views
{
    /// <summary>
    /// Lógica de interacción para LoggInView.xaml
    /// </summary>
    public partial class LoggInView : Window, IPasswordService
    {
     
        public LoggInView()
        {
            InitializeComponent();
        }

        public System.Security.SecureString GetPassword
        {
            get
            {
                return UserPassword.SecurePassword;
            }
        }

     
    }
}
