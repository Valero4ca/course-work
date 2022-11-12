using CommunityToolkit.Mvvm.Input;
using CourseWork.Model;
using System.Collections.ObjectModel;
using Bogus;
using static Bogus.DataSets.Name;


namespace CourseWork.ViewModel
{
    public partial class PatientViewModel : BaseViewModel
    {

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
            Gender random_gender = (Gender)gender_array.GetValue(new.Random().Next(gender_array.Length));

            Faker<PatientModel> patient = new Faker<PatientModel>()
            .StrictMode(true)
            .RuleFor(c => c.PatientID, f => new Random().Next().ToString().ToUpper())
            .RuleFor(c => c.Name, f => f.Name.FirstName())
            .RuleFor(c => c.Surname, f => f.Name.LastName())
            .RuleFor(c => c.DateofBirth, f => f.Date.Between(new DateTime(1914, 1, 1), new DateTime(2004, 1, 1))
            .RuleFor(c => c.Gender, f => "Gender")
            .RuleFor(c => c.Doctor, f => "Валерьянов В.И.");


            Patients.Add(patient);
        }

        [RelayCommand]
        void DeletePatient()

        {
            if(IsBusy)
            {
                return;
            }
            Patients.Remove(selectedPatient);
        }








    }
    [RelayCommand]

    void DeletePatient()
    {
        if (IsBusy)
        {
            return;
        }
        Patients.Remove(selectedPatient);
    }

}



