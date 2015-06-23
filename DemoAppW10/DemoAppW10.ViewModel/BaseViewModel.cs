using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DemoAppW10.Common.Interface;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace DemoAppW10.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private static BaseViewModel baseViewModel;

        public static INavigationService NavigationService { get; set; }


        private static IHelper _HelperClass;
        public static IHelper HelperClass
        {
            get 
            { return _HelperClass; }
            set
            {
                _HelperClass = value;
            }
        }

        #region Constructor

        public BaseViewModel()
        {

        }

        #endregion

        #region Single Instance

        public static BaseViewModel GetSingleInstance()
        {
            if (baseViewModel == null)
                baseViewModel = new BaseViewModel();
            return baseViewModel;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value)) return false;

            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;

        }
    
        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="CallerMemberNameAttribute"/>.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      
    }
}

