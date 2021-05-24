using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LazyLoading
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new TabViewModel();
            this.simTab.SelectionIndicatorSettings = new SelectionIndicatorSettings() { Position = SelectionIndicatorPosition.Fill, Color = Color.FromHex("#FF00AFF0") };
            this.ContactTab1.SelectionIndicatorSettings = this.ContactTab2.SelectionIndicatorSettings = this.CallsTab1.SelectionIndicatorSettings = this.CallTab2.SelectionIndicatorSettings = new SelectionIndicatorSettings() { Position = SelectionIndicatorPosition.Top };
        }

    }

    public class CustomViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Device.RuntimePlatform == "Android")
            {
                if (parameter != null && parameter is string)
                    return "NestedTab.ttf#" + parameter.ToString();
                else
                    return "NestedTab.ttf";
            }
            else if (Device.RuntimePlatform == "iOS")
            {

                return "NestedTab";

            }
            else
            {
                var ff= "/Assets/NestedTab.ttf#NestedTab";
               var nested = "NestedTab.ttf#NestedTab";
                return ff;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
  }
