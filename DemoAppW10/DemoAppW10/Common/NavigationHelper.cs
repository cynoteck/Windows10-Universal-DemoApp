using System;
using DemoAppW10.Common.Interface;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DemoAppW10.Views;

namespace DemoAppW10.Common
{
    public class NavigationHelper : INavigationService
    {
        private Page Page { get; set; }

        private Frame Frame { get { return this.Page.Frame; } }

        public NavigationHelper()
        { }

        public virtual void GoBack()
        {
            if (((Frame)Window.Current.Content) != null && ((Frame)Window.Current.Content).CanGoBack)
                ((Frame)Window.Current.Content).GoBack();
        }

        public void NavigateToPage(Entities.Enums.Views type)
        {
            Type pageType = PageRouting[type];
            ((Frame)Window.Current.Content).Navigate(pageType);
        }

        public void NavigateToPage(Entities.Enums.Views type, object navigationParameter)
        {
            Type pageType = PageRouting[type];
            ((Frame)Window.Current.Content).Navigate(pageType, navigationParameter);
        }
        public virtual bool CanGoBack()
        {
            return this.Frame != null && this.Frame.CanGoBack;
        }

        public Dictionary<Entities.Enums.Views, Type> PageRouting = new Dictionary<Entities.Enums.Views, Type>()
        {
            {Entities.Enums.Views.HomePage,typeof(HomePage)},
             {Entities.Enums.Views.SplitView,typeof(Views.SplitView)},
             {Entities.Enums.Views.RelativePanel,typeof(Views.RelativePanel)},
              {Entities.Enums.Views.MediaTransportControl,typeof(MediaTransportControl)},
                {Entities.Enums.Views.MapsControl,typeof(MapsControl)},
                    {Entities.Enums.Views.CalendarDatePicker,typeof(Views.CalendarDatePicker)},
                      {Entities.Enums.Views.CalendarViewControl,typeof(CalendarViewControl)},
                      {Entities.Enums.Views.NewFeatures,typeof(NewFeatures)},
                       {Entities.Enums.Views.ChangedOldControl,typeof(ChangedOldControl)},
                       {Entities.Enums.Views.TransformEffect,typeof(TransformEffect)},
                        {Entities.Enums.Views.PivotControlPage,typeof(PivotControlPage)},
                          {Entities.Enums.Views.PickerControl,typeof(PickerControl)},
                          {Entities.Enums.Views.ContentDialogControl,typeof(ContentDialogControl)},
                           {Entities.Enums.Views.RegisterPage,typeof(RegisterPage)},
                            {Entities.Enums.Views.AdaptiveUI,typeof(AdaptiveUI)},

        };



    }
}
