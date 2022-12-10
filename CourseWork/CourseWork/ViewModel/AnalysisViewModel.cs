using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CourseWork.Model;
using CourseWork.View.Popups;

namespace CourseWork.ViewModel
{
    public partial class AnalysisViewModel:BaseViewModel,IQueryAttributable
    {
        public PatientModel patient { get; set; } = new();
        public AddNewAnalysis addNewAnalysis;
        public Analysis AnalysisNew { get; set; } = new();
        public ObservableCollection<Analysis> AnalysisCollection { get; set; }=new();
        public void ApplyQueryAttributes(IDictionary<string,object>query)
        {
            patient = query["Patient"] as PatientModel;
            foreach(var analysis in patient.Analysislist)
            {
                AnalysisCollection.Add(analysis);
            }
            OnPropertyChanged(nameof(patient));
        }
        [RelayCommand]
        void OpenAnalysisPopup()
        {
            if (IsBusy)
            {
                return;
            }

            addNewAnalysis = new AddNewAnalysis(this);
            App.Current.MainPage.ShowPopup(addNewAnalysis);
        }

        [RelayCommand]
        void CloseAnalysisPopup()
        {
            if (IsBusy)
            {
                return;
            }

            addNewAnalysis.Close();
           AnalysisNew = new();


        }
        
        [RelayCommand]
        void AddAnalysisNew()
        {
            if (IsBusy)
            {
                return;
            }
            if (AnalysisNew == null)
            {
                return;
            }

            AnalysisCollection.Add(AnalysisNew);

            addNewAnalysis.Close();
            AnalysisNew = new();
        }

        [RelayCommand]
        async void ExortAnalysesToJSON()
        {
            if(IsBusy)
            {
                return;
            }

            var encoderSettings = new TextEncoderSettings();
            encoderSettings.AllowRanges(UnicodeRanges.All);

            var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(encoderSettings) };
            string jsonStringPatient = JsonSerializer.Serialize(patient, options);

            var filePath = $"C:\\Users\\Kirill Banakh\\Downloads\\Export_{DateTime.Now.ToFileTimeUtc().ToString()}.json";

            FileStream fs = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);

            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write(jsonStringPatient);
                sw.Flush();
            }
            await Application.Current.MainPage.DisplayAlert("Export", $"File was saved: {filePath}", "OK");
            fs.Close();
        }
    }
}
