namespace exams4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void start_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());

        }
    }
}