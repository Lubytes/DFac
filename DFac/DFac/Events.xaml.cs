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

namespace DFac
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Events : Page
    {
        public Events()
        {
            this.InitializeComponent();
        }


        private void HamburgerRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (!this.SplitView.IsPaneOpen)
            {
                this.SplitView.IsPaneOpen = true;
            }
            else
            {
                this.SplitView.IsPaneOpen = false;
            }
        }

        private void HomeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(MainPage))
            {
                this.Frame.Navigate(typeof(MainPage));
            }
        }



        private void InvolveRadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcademicsRadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EventsRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Events))
            {
                this.Frame.Navigate(typeof(Events));
            }
        }

        private void ExitPointer(object sender, PointerRoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = false;
        }
    }
}
