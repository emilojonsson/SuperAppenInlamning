namespace SuperAppenInlamning;

public partial class MainPage : ContentPage
{
	int count = 0;
    int count2 = 0;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count += new Random().Next(-10, 10);

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
    private void OnCounterClicked1(object sender, EventArgs e)
    {
        count2 ++;

        if (count2 == 1)
            CounterBtn1.Text = $"Clicked {count2} time";
        else
            CounterBtn1.Text = $"Clicked {count2} times";

        SemanticScreenReader.Announce(CounterBtn1.Text);
    }

}

