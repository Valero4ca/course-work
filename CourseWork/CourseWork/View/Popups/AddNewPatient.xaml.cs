using CommunityToolkit.Maui.Views;
using CourseWork.Model;
using CourseWork.ViewModel;


namespace CourseWork.View.Popups;

public partial class AddNewPatient : Popup
{
	public AddNewPatient(PatientViewModel viewModel,PatientModel patient)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}