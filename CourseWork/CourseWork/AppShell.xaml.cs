using CourseWork.View;

namespace CourseWork;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AnalysisView), typeof(AnalysisView));
	}
}
