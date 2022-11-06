using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class PatientModel : PersonModel
    {
        public string PatientID { get; set; }
        public string Doctor{ get; set; }
    }
}
