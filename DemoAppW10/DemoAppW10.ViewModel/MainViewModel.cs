using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoAppW10.Entities.Enums;
using DemoAppW10.Common;
using System.Threading.Tasks;
using Windows.UI.Popups;
using System.Collections.ObjectModel;
using DemoAppW10.Entities;

namespace DemoAppW10.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        private ObservableCollection<NewFeatures> visualStudioNewFeaturesDetails;
        public ObservableCollection<NewFeatures> VisualStudioNewFeaturesDetails
        {
            get
            {
                return visualStudioNewFeaturesDetails;
            }
            set
            {
                SetProperty(ref visualStudioNewFeaturesDetails, value);
            }
        }

        private ObservableCollection<OldFeatures> visualStudioOldFeaturesDetails;
        public ObservableCollection<OldFeatures> VisualStudioOldFeaturesDetails
        {
            get
            {
                return visualStudioOldFeaturesDetails;
            }
            set
            {
                SetProperty(ref visualStudioOldFeaturesDetails, value);
            }
        }

      

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);
            }
        }

        private string _fatherName;
        public string FatherName
        {
            get
            {
                return _fatherName;
            }
            set
            {
                SetProperty(ref _fatherName, value);
            }
        }

        private string _motherName;
        public string MotherName
        {
            get
            {
                return _motherName;
            }
            set
            {
                SetProperty(ref _motherName, value);
            }
        }


        private NewFeatures selectNewFeatures;
        public NewFeatures SelectNewFeatures
        {
            get
            {
                return this.selectNewFeatures;
            }
            set
            {
                SetProperty(ref this.selectNewFeatures, value);
                if (value != null)
                {
                    this.CheckedNewFeatures(value);
                }
            }
        }

        private OldFeatures selectUpdateControl;
        public OldFeatures SelectUpdateControl
        {
            get
            {
                return this.selectUpdateControl;
            }
            set
            {
                SetProperty(ref this.selectUpdateControl, value);
                if (value != null)
                {
                    this.CheckedUpdateControl(value);
                }
            }
        }



        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.VisualStudioNewFeaturesDetails = new ObservableCollection<NewFeatures>();
            this.VisualStudioOldFeaturesDetails = new ObservableCollection<OldFeatures>();
            
        }

        #endregion

        #region SingleInstance

        public static MainViewModel currentInstance = null;
        public static MainViewModel GetSingleInstance()
        {

            if (currentInstance == null)
            {
                currentInstance = new MainViewModel();
            }
            return currentInstance;
        }

        #endregion

        #region DelegateCommand

        private DelegateCommand submitButtonCommand;
        public DelegateCommand SubmitButtonCommand
        {
            get
            {
                if (submitButtonCommand == null)
                    submitButtonCommand = new DelegateCommand(SubmitButtonCommandClick);
                return submitButtonCommand;
            }
        }



        private DelegateCommand newControlCommand;
        public DelegateCommand NewControlCommand
        {
            get
            {
                if (newControlCommand == null)
                    newControlCommand = new DelegateCommand(NewControlCommandClick);
                return newControlCommand;
            }
        }

        private DelegateCommand updateControlCommand;
        public DelegateCommand UpdateControlCommand
        {
            get
            {
                if (updateControlCommand == null)
                    updateControlCommand = new DelegateCommand(UpdateControlCommandClick);
                return updateControlCommand;
            }
        }


        #endregion
        private void CheckedNewFeatures(NewFeatures value)
        {
            if (value.Name == "SplitView")
            {
                NavigationService.NavigateToPage(Views.SplitView);
            }
            else if (value.Name == "RelativePanel")
            {
                NavigationService.NavigateToPage(Views.RelativePanel);
            }
            else if (value.Name == "CalendarView")
            {
                NavigationService.NavigateToPage(Views.CalendarViewControl);
            }
            else if (value.Name == "CalendarDatePicker")
            {
                NavigationService.NavigateToPage(Views.CalendarDatePicker);
            }
            else if (value.Name == "MediaTransportControls")
            {
                NavigationService.NavigateToPage(Views.MediaTransportControl);
            }
            else if (value.Name == "MapsControl")
            {
                NavigationService.NavigateToPage(Views.MapsControl);
            }
            else if (value.Name == "3D Transform Effect")
            {
                NavigationService.NavigateToPage(Views.TransformEffect);
            }
            else if (value.Name == "ContentDialogControl")
            {
                NavigationService.NavigateToPage(Views.ContentDialogControl);
            }
            else if (value.Name == "AdaptiveUI")
            {
               NavigationService.NavigateToPage(Views.AdaptiveUI);
            }
        }

        private void CheckedUpdateControl(OldFeatures value)
        {
            if (value.Name == "CommandBar & AppBar")
            {
                NavigationService.NavigateToPage(Views.RegisterPage);
            }

            else if (value.Name == "PivotControl")
            {
                NavigationService.NavigateToPage(Views.PivotControlPage);
            }

            else if (value.Name == "PickerControl")
            {
                NavigationService.NavigateToPage(Views.PickerControl);
            }
        }

        private async void SubmitButtonCommandClick()
        {
            if (Name != null && FatherName != null && MotherName != null)
            {
                MessageDialog message = new MessageDialog("Successfully");
                await message.ShowAsync();

                NavigationService.NavigateToPage(Views.HomePage);
            }
            else
            {
                MessageDialog message = new MessageDialog("First Enter All Field Data");
                await message.ShowAsync();
            }
        }

        public void VisualStudioNewFeaturesData()
        {
            if (VisualStudioNewFeaturesDetails.Count == 0)
            {
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "SplitView" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "RelativePanel" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "CalendarView" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "CalendarDatePicker" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "MediaTransportControls" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "MapsControl" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "3D Transform Effect" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "ContentDialogControl" });
                this.VisualStudioNewFeaturesDetails.Add(new NewFeatures() { Name = "AdaptiveUI" });
            }
        }

        public void VisualStudioChangedOldFeturesData()
        {
            if (VisualStudioOldFeaturesDetails.Count == 0)
            {
                this.VisualStudioOldFeaturesDetails.Add(new OldFeatures() { Name = "CommandBar & AppBar" });
                this.VisualStudioOldFeaturesDetails.Add(new OldFeatures() { Name = "PivotControl" });
                this.VisualStudioOldFeaturesDetails.Add(new OldFeatures() { Name = "PickerControl" });
               
            }
        }

        private void NewControlCommandClick()
        {

            NavigationService.NavigateToPage(Views.NewFeatures);
        }

        private void UpdateControlCommandClick()
        {
            NavigationService.NavigateToPage(Views.ChangedOldControl);
        }

    }
}
