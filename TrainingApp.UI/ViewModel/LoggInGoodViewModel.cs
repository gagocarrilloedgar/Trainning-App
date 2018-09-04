using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;


namespace TrainingApp.UI.ViewModel
{
    public class LoggInGoodViewModel : ViewModelBase
    {
        #region Properties
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                RaisePropertyChanged("Message");
            }
        }
        #endregion
        public LoggInGoodViewModel()
        {


        }

    }
}