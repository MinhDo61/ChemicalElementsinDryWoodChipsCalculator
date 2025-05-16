namespace BasicCalculator;

public partial class DeterminationOfHydrogenPage : ContentPage
{
    public DeterminationOfHydrogenPage(DeterminationOfHydrogenViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
