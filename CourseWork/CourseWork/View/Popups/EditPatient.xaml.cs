using CommunityToolkit.Maui.Views;
using CourseWork.Model;
using CourseWork.ViewModel;


namespace CourseWork.View.Popups;

public partial class EditPatient : Popup
{
	public EditPatient(PatientViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}