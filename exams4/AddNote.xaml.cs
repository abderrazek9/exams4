namespace exams4;

public partial class AddNote : ContentPage
{
    private Home _homePage;
    public AddNote(Home homePage)
	{
		InitializeComponent();
        _homePage = homePage;
        LoadCheckBoxItems(); // Load items when the page is initialized

    }


 

    private void DisplayCheckBoxes(int category)
    {
        // Clear previous checkboxes
        CheckBoxContainer.Children.Clear();

        // Add 100 checkboxes with labels
        for (int i = 1; i <= 100; i++)
        {
            var stack = new StackLayout { Orientation = StackOrientation.Horizontal };
            var checkBox = new CheckBox();
            var label = new Label { Text = $"CheckBox {category}-{i}", VerticalOptions = LayoutOptions.Center };

            stack.Children.Add(checkBox);
            stack.Children.Add(label);

            CheckBoxContainer.Children.Add(stack);
        }
    }

    private void LoadCheckBoxItems()
    {
        CheckBoxContainer.Children.Clear();

        var items = new List<string>
        {
            "لحم دجاج", "لحم خروف", "لحم بقري", "بطاطا", "جزر", "بصل", "ثوم", "طماطم",
            "باذنجان", "فلفل", "خيار", "سلاطة خص", "الفول", "لفت", "بازلاء", "فاصولاء",
            "حمص", "عدس", "معكرونة", "سباغتي", "محمصة", "البيض", "الجليب", "الخبز",
            "البرتقال", "المشمش", "الخوخ", "البطيخ", "الموز", "الفروالة", "اناناس",
            "التمر", "كيوي", "التفاح", "الكرز", "الاجاص", "الرمان", "التين", "العنب",
            "izem", "ramy", "hamoud", "شربة", "راس الحانوت", "فلفل اسود", "فلفل احمر",
            "كمون", "زعفران", "جومبو", "زيت", "زيت زيتون", "ماء"
        };

        foreach (var item in items)
        {
            var stack = new StackLayout { Orientation = StackOrientation.Horizontal };
            var checkBox = new CheckBox();
            checkBox.CheckedChanged += (s, e) =>
            {
                _homePage.LoadSelectedItems();   // Update selected items on home page immediately
            };
            var label = new Label { Text = item, VerticalOptions = LayoutOptions.Center };

            stack.Children.Add(checkBox);
            stack.Children.Add(label);

            CheckBoxContainer.Children.Add(stack);
        }
    }


    private void AddItemClicked_Clicked(object sender, EventArgs e)
    {
        string newItemText = NewItemEntry.Text?.Trim();

        if (!string.IsNullOrEmpty(newItemText))
        {
            var stack = new StackLayout { Orientation = StackOrientation.Horizontal };
            var checkBox = new CheckBox();
            checkBox.CheckedChanged += (s, e) =>
            {
                _homePage.LoadSelectedItems();   // Update selected items on home page immediately
            };
            var label = new Label { Text = newItemText, VerticalOptions = LayoutOptions.Center };

            stack.Children.Add(checkBox);
            stack.Children.Add(label);

            CheckBoxContainer.Children.Add(stack);
            NewItemEntry.Text = string.Empty; // Clear the entry field after adding
        }
    }

    private void AddInStack_Clicked(object sender, EventArgs e)
    {

    }
}