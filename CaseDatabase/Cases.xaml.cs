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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaseDatabase
{
    /// <summary>
    /// Interaction logic for Case.xaml
    /// </summary>
    public partial class Cases : UserControl
    {
        public event EventHandler BackClicked;

        public Cases()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (BackClicked != null)
            {
                BackClicked(this, EventArgs.Empty);
            }
        }
    }
}
