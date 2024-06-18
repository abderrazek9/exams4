namespace exams4;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    bool show = true;

    private void eye_Clicked(object sender, EventArgs e)
    {
        if (show == true)
        {
            inPutpass.IsPassword = false;
            show = false;
        }
        else
        {
            inPutpass.IsPassword = true;
            show = true;
        }
    }

    private void forgot_Clicked(object sender, EventArgs e)
    {

    }

    private void signIn_Clicked(object sender, EventArgs e)
    {
        

    }

    private void Sing_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignUp());
    }

    private void Skip_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Home());
    }
}