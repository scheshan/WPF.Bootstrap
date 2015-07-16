using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.Bootstrap.Controls
{
    [TemplatePart(Name = PART_MaxButton, Type = typeof(Button))]
    [TemplatePart(Name = PART_MinButton, Type = typeof(Button))]
    [TemplatePart(Name = PART_RestoreButton, Type = typeof(Button))]
    [TemplatePart(Name = PART_CloseButton, Type = typeof(Button))]
    public class Dialog : Window
    {
        private const string PART_MaxButton = "PART_MaxButton";
        private const string PART_MinButton = "PART_MinButton";
        private const string PART_RestoreButton = "PART_RestoreButton";
        private const string PART_CloseButton = "PART_CloseButton";

        static Dialog()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Dialog), new FrameworkPropertyMetadata(typeof(Dialog)));
        }

        private Button btnMax;
        private Button btnMin;
        private Button btnRestore;
        private Button btnClose;

        public Dialog()
        {
            this.SetResourceReference(StyleProperty, typeof(Dialog));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.btnMax = this.GetTemplateChild(PART_MaxButton) as Button;
            this.btnMin = this.GetTemplateChild(PART_MinButton) as Button;
            this.btnRestore = this.GetTemplateChild(PART_RestoreButton) as Button;
            this.btnClose = this.GetTemplateChild(PART_CloseButton) as Button;

            if (this.btnMax != null)
            {
                this.btnMax.Click += btnMax_Click;
            }
            if (this.btnMin != null)
            {
                this.btnMin.Click += btnMin_Click;
            }
            if (this.btnRestore != null)
            {
                this.btnRestore.Click += btnRestore_Click;
            }
            if (this.btnClose != null)
            {
                this.btnClose.Click += btnClose_Click;
            }
        }

        void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Normal;
        }

        void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        void btnMax_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }
    }
}
