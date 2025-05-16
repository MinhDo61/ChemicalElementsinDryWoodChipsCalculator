# BasicCalculator - Carbon Content Calculator

## Overview
BasicCalculator is a .NET 8.0 MAUI application designed to calculate the carbon content in different types of wood and plant materials. The app determines the hydrogen (H), oxygen (O), and nitrogen (N) content in dry, ash-free wood chips, based on the LVS EN ISO 18125 standard. This tool is useful for biomass analysis, environmental studies, and energy production calculations.

## Features
- Elemental Composition Analysis – Calculates H, O, and N content in dry wood chips.
- Support for Multiple Wood Types – Choose from different types of wood, including tree trunks, bark, and whole trees.
- Real-time Input Validation – Ensures entered values are within acceptable ranges (0.1% - 100%).
- Interactive UI – Provides a smooth and intuitive user experience for easy navigation.
- Instant Calculation – Results are displayed in real-time after data entry.
- MAUI-based Cross-platform Support – Runs on Android, iOS, Windows, and macOS.

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/BasicCalculator.git
   ```
2. Navigate to the project directory:
   ```sh
   cd BasicCalculator
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Build and run the application:
   ```sh
   dotnet build
   dotnet run
   ```

Alternatively, you can open the project in Visual Studio 2022, ensure that the .NET MAUI workload is installed, and run the project from the IDE.

## Usage Guide
1. Open the application.
2. Select the type of wood from the dropdown list.
3. Enter the hydrogen, oxygen, and ash content values.
4. Click Calculate to process the data.
5. View the calculated results for the selected wood type.
6. Use the navigation buttons to move between element-specific calculation pages.

## Code Structure
- `ViewModel/DeterminationOfHydrogenViewModel.cs` – Hydrogen calculation.
- `ViewModel/DeterminationOfOxygenViewModel.cs` – Oxygen calculation.
- `ViewModel/DeterminationOfNitrogenViewModel.cs` – Nitrogen calculation.
- `ViewModel/MainPageViewModel.cs` – Page navigation logic.
- `ViewModel/BaseViewModel.cs` – Input validation.
- `Views/DeterminationOfHydrogenPage.xaml/cs` – UI for hydrogen content.
- `Views/DeterminationOfOxygenPage.xaml/cs` – UI for oxygen content.
- `Views/DeterminationOfNitrogenPage.xaml/cs` – UI for nitrogen content.
- `Views/MainPage.xaml/cs` – Main navigation page.
- `Views/App.xaml
- `Views/AppShell.xaml/cs


## Supported Wood Types
The application allows calculations for different wood types, including:
- Unknown wood type
- Tree trunk (without bark, needles, and leaves)
- Whole tree
- Logging residues
- Bark
- Understory wood

## Requirements
To run the application, ensure you have:
- .NET 8.0 SDK installed.
- Visual Studio 2022 with the .NET MAUI workload enabled.
- A Windows, macOS, Android, or iOS device for testing.

## Future Enhancements
- Carbon Content Calculation – Adding direct carbon percentage estimation.
- Database Storage – Saving historical calculation results.
- Graphical Representation – Displaying element composition as charts.

## License
Licensed under the me as for this subject- Designing and Building a Mobile App 6002.

