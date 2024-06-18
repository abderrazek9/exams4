namespace exams4;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        LoadSelectedItems();
        DataStore.Instance.Items.CollectionChanged += (s, e) => LoadSelectedItems();
    }


    public void LoadSelectedItems()
    {
        TaskListContainer.Children.Clear();

        var selectedItems = DataStore.Instance.Items.Where(i => i.IsChecked).Select(i => i.Text).ToList();

        foreach (var item in selectedItems)
        {
            var label = new Label { Text = item };
            TaskListContainer.Children.Add(label);
        }
    }


    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNote(this)); // Pass the Home instance

    }

    private void logout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}