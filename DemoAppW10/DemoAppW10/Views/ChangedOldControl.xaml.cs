using DemoAppW10.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoAppW10.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangedOldControl : Page
    {
        public MainViewModel mainViewModel;
        public ChangedOldControl()
        {
            this.InitializeComponent();
            this.Loaded += ChangedOldControl_Loaded;
        }

        private void ChangedOldControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.mainViewModel = MainViewModel.GetSingleInstance();
            this.DataContext = mainViewModel;
            this.mainViewModel.VisualStudioChangedOldFeturesData();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
