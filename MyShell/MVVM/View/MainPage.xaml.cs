using MyShell.MVVM.View;

namespace MyShell
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            if (isUsernameEmpty)
            {
                UsernameEntry.Placeholder = "Vul je gebruikersnaam in!";
            }
            else if (isPasswordEmpty)
            {
                PasswordEntry.Placeholder = "Vul je wachtwoord in!";
            }
            else
            {
                Navigation.PushAsync(new TabbedPage());
            }
        }
    }
}
