using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.Bootstrap.Controls
{
    public class BootstrapPanel : HeaderedContentControl
    {
        #region static members

        public static readonly DependencyProperty FooterProperty =
            DependencyProperty.Register("Footer", typeof(object), typeof(BootstrapPanel), new PropertyMetadata(null, OnFooterChanged));

        public static readonly DependencyProperty FooterTemplateProperty =
            DependencyProperty.Register("FooterTemplate", typeof(DataTemplate), typeof(BootstrapPanel), new PropertyMetadata(null));

        public static readonly DependencyProperty FooterTemplateSelectorProperty =
            DependencyProperty.Register("FooterTemplateSelector", typeof(DataTemplateSelector), typeof(BootstrapPanel), new PropertyMetadata(null));

        public static readonly DependencyProperty HasFooterProperty =
            DependencyProperty.Register("HasFooter", typeof(bool), typeof(BootstrapPanel), new PropertyMetadata(false));

        public static readonly DependencyProperty FooterStringFormatProperty =
            DependencyProperty.Register("FooterStringFormat", typeof(string), typeof(BootstrapPanel), new PropertyMetadata(null));

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(BootstrapPanelType), typeof(BootstrapPanel), new PropertyMetadata(BootstrapPanelType.Default));

        #endregion

        #region static methods

        private static void OnFooterChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var panel = (BootstrapPanel)obj;
            panel.HasFooter = e.NewValue != null;
        }

        #endregion

        #region properties

        public object Footer
        {
            get { return (object)GetValue(FooterProperty); }
            set { SetValue(FooterProperty, value); }
        }

        public DataTemplate FooterTemplate
        {
            get { return (DataTemplate)GetValue(FooterTemplateProperty); }
            set { SetValue(FooterTemplateProperty, value); }
        }

        public DataTemplateSelector FooterTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(FooterTemplateSelectorProperty); }
            set { SetValue(FooterTemplateSelectorProperty, value); }
        }

        [Bindable(false)]
        [Browsable(false)]
        public bool HasFooter
        {
            get { return (bool)GetValue(HasFooterProperty); }
            private set { SetValue(HasFooterProperty, value); }
        }

        public string FooterStringFormat
        {
            get { return (string)GetValue(FooterStringFormatProperty); }
            set { SetValue(FooterStringFormatProperty, value); }
        }

        public BootstrapPanelType Type
        {
            get { return (BootstrapPanelType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        #endregion

        static BootstrapPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BootstrapPanel), new FrameworkPropertyMetadata(typeof(BootstrapPanel)));
        }
    }

    public enum BootstrapPanelType
    {
        Default = 1,
        Primary = 2,
        Info = 3,
        Success = 4,
        Warning = 5,
        Danger = 6
    }
}
