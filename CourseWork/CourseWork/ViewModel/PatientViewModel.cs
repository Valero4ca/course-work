using CommunityToolkit.Mvvm.Input;
using CourseWork.Model;
using System.Collections.ObjectModel;
using Bogus;
using static Bogus.DataSets.Name;
using CourseWork.View.Popups;
using CommunityToolkit.Maui.Views;

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
            .RuleFor(c => c.Doctor, f => "Петров И.А.");


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
            addNewPatientPopup.Close();

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
    }
}
     
   





