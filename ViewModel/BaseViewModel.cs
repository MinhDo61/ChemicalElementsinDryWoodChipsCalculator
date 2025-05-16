namespace BasicCalculator.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    protected bool isUserProvidedValuesValid;

    protected async Task ValidateUserProvidedValues(decimal firstValue, decimal secondValue)
    {
        if (Convert.ToDecimal(firstValue) > 0 && Convert.ToDecimal(secondValue) > 0)
        {
            if (firstValue > 0 && firstValue <= 100 && secondValue > 0 && secondValue <= 100)
            {
                isUserProvidedValuesValid = true;
            }
            else
            {
                isUserProvidedValuesValid = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Both fields can contain numbers no smaller than 0 and no larger than 100",
                    "OK"
                );
            }
        }
        else
        {
            isUserProvidedValuesValid = false;
            await Application.Current.MainPage.DisplayAlert(
                "Error",
                "The fields can only contain digits, and they cannot be smaller than 0",
                "OK"
            );
        }
    }
}
