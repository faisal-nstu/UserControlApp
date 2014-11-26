using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UserControlApp
{
    public sealed partial class CustomSlider : UserControl
    {
        public static readonly DependencyProperty MinimumProperty = 
            DependencyProperty.Register("Minimum", typeof (int), typeof (CustomSlider), new PropertyMetadata(0));

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof (int), typeof (CustomSlider), new PropertyMetadata(100));

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof (int), typeof (CustomSlider), new PropertyMetadata(0));

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof (string), typeof (CustomSlider), new PropertyMetadata(String.Empty));

        public static readonly DependencyProperty ValueSuffixProperty =
            DependencyProperty.Register("ValueSuffix", typeof (string), typeof (CustomSlider),
                new PropertyMetadata(String.Empty));


        public int Minimum
        {
            get { return (int) GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value);}
        }

        public int Maximum
        {
            get { return (int) GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty,value);}
        }

        public int Value {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value);}
        }

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public string ValueSuffix
        {
            get { return (string)GetValue(ValueSuffixProperty); }
            set { SetValue(ValueSuffixProperty, value); }
        }

        public CustomSlider()
        {
            this.InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.Value_edit_textbox.IsEnabled = true;
            this.Value_edit_textbox.Focus(FocusState.Programmatic);
        }

        private void Value_edit_textbox_keyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                this.Value_edit_textbox.IsEnabled = false;
            }
        }

        private void Value_edit_textbox_lost_focus(object sender, RoutedEventArgs e)
        {
            this.Value_edit_textbox.IsEnabled = false;
        }
    }
}
