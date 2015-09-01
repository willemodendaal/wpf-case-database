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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void login_LoginSuccess(object sender, EventArgs e)
        {
            PageAnimationHelper.SlideFromRight(this, this.casesView);
            PageAnimationHelper.SlideToLeft(this, this.login);
        }

        private void casesView_BackClicked(object sender, EventArgs e)
        {
            PageAnimationHelper.SlideToRight(this, this.casesView);
            PageAnimationHelper.SlideFromLeft(this, this.login);
        }
    }
}
