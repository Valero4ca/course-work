using CourseWork.ViewModel;

namespace CourseWork;

public partial class MainPage : ContentPage
{
	public MainPage(PatientViewModel patientViewModel)
	{
		InitializeComponent();
		BindingContext = patientViewModel;
	}
}
