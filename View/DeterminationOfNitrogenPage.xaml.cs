namespace BasicCalculator;

public partial class DeterminationOfNitrogenPage : ContentPage
{
    public DeterminationOfNitrogenPage(DeterminationOfNitrogenViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
