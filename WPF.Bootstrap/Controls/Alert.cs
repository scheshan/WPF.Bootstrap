using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.Bootstrap.Controls
{
    public class Alert : ContentControl
    {
        static Alert()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Alert), new FrameworkPropertyMetadata(typeof(Alert)));
        }

        public AlertType Type
        {
            get { return (AlertType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(AlertType), typeof(Alert), new PropertyMetadata(AlertType.Success));
    }

    public enum AlertType
    {
        Success = 1,
        Info = 2,
        Warning = 3,
        Danger = 4
    }
}
