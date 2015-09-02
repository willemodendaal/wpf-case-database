using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaseDatabase
{
    /// <summary>
    /// Interaction logic for InfoPopup.xaml
    /// </summary>
    public partial class InfoPopup : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(InfoPopup), new FrameworkPropertyMetadata("Info"));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public InfoPopup()
        {
            InitializeComponent();
        }

        public async Task ShowAsync(PopupStyle style)
        {
            if (style == PopupStyle.Error)
            {
                //Show error style.
                Text = "ACCESS DENIED";
                border.Style = (Style)this.FindResource("errorStyle");
                var storyBoard = (Storyboard)this.FindResource("flashInAndHide");
                await storyBoard.BeginAsync(this);
            }
            else
            {
                //Show success style.
                Text = "Access Granted";
                border.Style = (Style)this.FindResource("successStyle");
                var storyBoard = (Storyboard)this.FindResource("fadeInAndHide");
                await storyBoard.BeginAsync(this);
            }
        }

        public enum PopupStyle
        {
            Success,
            Error
        }
    }
}
