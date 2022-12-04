using CommunityToolkit.Mvvm.Input;
using CourseWork.Model;
using System.Collections.ObjectModel;
using Bogus;
using static Bogus.DataSets.Name;
using CourseWork.View.Popups;
using CommunityToolkit.Maui.Views;
using CourseWork.View;
using System.Data;

namespace CourseWork.ViewModel
{
    public partial class PatientViewModel : BaseViewModel
    {
        public AddNewPatient addNewPatientPopup;
        public EditPatient editPatientPopup;
        public PatientModel patient_to_add { get; set; } = new();

        public PatientModel patient_to_edit { get; set; } = new();
        public ObservableCollection<PatientModel> Patients { get; set; } = new();


        public PatientModel selectedPatient { get; set; } = new();


        List<Analysis> GenerateAnalysis(int size)
        {

            List<Analysis> analysisList = new();

            var random = new Random();
            for(int i=0; i<size; i++)
            {
                Faker<Analysis> analysis=new Faker<Analysis>()
                    .StrictMode(true)
                    .RuleFor(c => c.ID, f => random.Next().ToString("X8").ToUpper())
                    .RuleFor(c => c.DataAnaliza, f => f.Date.Between(new DateTime(2004, 1, 1)), DateTime.Today)
                    .RuleFor(c => c.Obshchiybilirybin, f => random.NextDouble() *(20.5-0)+0)
                    .RuleFor(c => c.Nepryamoybilirybin, f => random.NextDouble() *(5.1-0)+0)
                    .RuleFor(c => c.Pryamoybilirybin, f => random.NextDouble() *(16.5-0)+0)
                    .RuleFor(c => c.Kholestirin, f => random.NextDouble() * (5.2-0)+0)
                    .RuleFor(c => c.Glukoza, f => random.NextDouble() * (5.83 - 3.89) + 3.89);

                analysisList.Add(analysis);
            }
            analysisList.Sort((x, y) => y.DataAnaliza.CompareTo(x.DataAnaliza));
            return analysisList;
        }
        [RelayCommand]
        void StartDemo()


        {
            if (IsBusy)
            {
                return;
            }

            Array gender_array = Enum.GetValues(typeof(Gender));
            Gender random_gender = (Gender)gender_array.GetValue(new Random().Next(gender_array.Length));

            Faker<PatientModel> patient = new Faker<PatientModel>()
            .StrictMode(true)
            .RuleFor(c => c.PatientID, f => (new Random().Next().ToString("X8").ToUpper()))
            .RuleFor(c => c.Name, f => f.Name.FirstName(random_gender))
            .RuleFor(c => c.Surname, f => f.Name.LastName(random_gender))
            .RuleFor(c => c.DateofBirth, f => f.Date.Between(new DateTime(1914, 1, 1), new DateTime(2004, 1, 1)))
            .RuleFor(c => c.Gender, f => random_gender.ToString())
            .RuleFor(c => c.Doctor, f => "Петров И.А.")
            .RuleFor(c => c.AnalysisList, f => GenerateAnalysis(10));


            Patients.Add(patient);
        }
        [RelayCommand]
        void DeletePatient()

        {
            if (IsBusy)
            {
                return;
            }


            if (Patients.Count == 0)
            {
                return;
            }
            Patients.Remove(selectedPatient);
        }


        [RelayCommand]
        void OpenAddNewPatientPopup()
        {
            if (IsBusy)
            {
                return;
            }

            addNewPatientPopup = new AddNewPatient(this);
            App.Current.MainPage.ShowPopup(addNewPatientPopup);
        }


        [RelayCommand]
        void AddNewPatientPopup()
        {
            if (IsBusy)
            {
                return;
            }
            if (patient_to_add == null)
            {
                return;
            }
            

            Patients.Add(patient_to_add);
            patient_to_add = new();
            addNewPatientPopup.Close();

        }

        [RelayCommand]
        void CloseAddNewPatientPopup()
        {

            if (IsBusy)
            {
                return;
            }
            addNewPatientPopup.Close();
            patient_to_add = new();


        }

        [RelayCommand]
        void OpenEditPatientPopup()
        {
            if (IsBusy)
            {
                return;
            }

            editPatientPopup = new EditPatient(this);
            App.Current.MainPage.ShowPopup(editPatientPopup);
          
        }



        [RelayCommand]
        void EditPatient()
        {
            if (IsBusy)
            {
                return;
            }
            if (patient_to_edit == null)
            {
                return;
            }

            var index = Patients.IndexOf(selectedPatient);
            Patients[index]= selectedPatient;

            
            patient_to_edit = new();
            editPatientPopup.Close();

        }
        [RelayCommand]
        void CloseEditPatientPopup()
        {

            if (IsBusy)
            {
                return;
            }
            editPatientPopup.Close();
            patient_to_add= new();

        }
        [RelayCommand]
        async Task OpenAnalysisPage()
        {
            if (IsBusy)
            {
                return;
            }

            if(selectedPatient==null)
            {
                return;
            }
            if(selectedPatient.PatientID==null)
            {
                return;
            }
            await Shell.Current.GoToAsync(nameof(AnalysisView),
                new Dictionary<string,object>
                {
                    {"Patient",selectedPatient }
               
                });
        }
    }
}
     
   





