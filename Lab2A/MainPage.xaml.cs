namespace Lab2A;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        string weightInput = Input_Weight.Text;
        double weight = Convert.ToDouble(weightInput);
        string heightInput = Input_Height.Text;
        double height = Convert.ToDouble(heightInput);

        Output.Text = Math.Round((weight / (height * height)), 1) + " kg/m2";

        SemanticScreenReader.Announce(Output.Text);
    }
}