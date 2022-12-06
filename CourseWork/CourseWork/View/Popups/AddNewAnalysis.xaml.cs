using CommunityToolkit.Maui.Views;
using CourseWork.ViewModel;

namespace CourseWork.View.Popups;

public partial class AddNewAnalysis : Popup
{
	public AddNewAnalysis(AnalysisViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}