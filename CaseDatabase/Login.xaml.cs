using CaseDatabase.Models;
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
    public partial class Login : UserControl
    {
        private LoginModel _model;
        public event EventHandler LoginSuccess;
        public event EventHandler LoginFailure;
        
        public Login()
        {
            InitializeComponent();

            _model = new LoginModel();
            this.DataContext = _model;
        }

        private async void login_Click(object sender, RoutedEventArgs e)
        {
            //Fetch password directly from view. Not according to MVC, but needed because password
            //  is  secure string and we don't want it hanging around in memory.
            //The only correct password in this demo is 'password'.
            if (password.Password == "password")
            {
                await OnSuccess();
            }
            else
            {
                await OnFailure();
            }
        }

        private async Task OnSuccess()
        {
            //Show info popup.
            await infoPopup.ShowAsync(InfoPopup.PopupStyle.Success);
            
            //Raise success event. 
            if (LoginSuccess != null)
            {
                LoginSuccess(this, EventArgs.Empty);
            }
        }

        private async Task OnFailure()
        {
            //Show info popup.
            await infoPopup.ShowAsync(InfoPopup.PopupStyle.Error);

            //Raise failure event.
            if (LoginFailure != null)
            {
                LoginFailure(this, EventArgs.Empty);
            }
        }

    }
}
