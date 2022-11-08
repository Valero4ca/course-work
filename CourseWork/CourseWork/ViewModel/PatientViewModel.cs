using CommunityToolkit.Mvvm.Input;
using CourseWork.Model;
using System.Collections.ObjectModel;

namespace CourseWork.ViewModel
{
    public partial class PatientViewModel : BaseViewModel
    {

        public ObservableCollection<PatientModel> Patient { get; set; } = new();
        [RelayCommand]
        void StartDemo()
        {
            if (IsBusy)
            {
                return;
            }
            var patient = new PatientModel();
            patient.PatientID = "10";
            patient.Name = "Nikita";
            patient.Surname = "Laboda";
            //Patients.Add(patient);
        }
    }
}
