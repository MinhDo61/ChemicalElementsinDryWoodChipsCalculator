namespace BasicCalculator;

public partial class DeterminationOfOxygenPage : ContentPage
{
    public DeterminationOfOxygenPage(DeterminationOfOxygenViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
