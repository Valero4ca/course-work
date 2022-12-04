using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Model;

namespace CourseWork.ViewModel
{
    public partial class AnalysisViewModel:BaseViewModel,IQueryAttributable
    {
        public PatientModel patient { get; set; } = new();

        public ObservableCollection<Analysis> analysis { get; set; }=new();
        public void ApplyQueryAttributes(IDictionary<string,object>query)
        {
            patient = query["Patient"] as PatientModel;
            foreach(var analysis in patient.Analysislist)
            {
                AnalysisCollection.Add(analysis);
            }
            OnPropertyChanged(nameof(patient));
        }
    }
}
