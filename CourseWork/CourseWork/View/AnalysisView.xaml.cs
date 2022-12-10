using CourseWork.ViewModel;
namespace CourseWork.View;

public partial class AnalysisView : ContentPage
{
	public AnalysisView(AnalysisViewModel viewModel)
	{

        InitializeComponent();
		BindingContext = viewModel;
	}
}