using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Model;

namespace CourseWork.ViewModel
{
    public partial class AnalysisViewModel:BaseViewModel,IQueryAttributable
    {
        public PatientModel patient { get; set; } = new();
        public void ApplyQueryAttributes(IDictionary<string,object>query)
        {
            patient = query["Patient"] as PatientModel;
            OnPropertyChanged(nameof(patient));
        }
    }
}
