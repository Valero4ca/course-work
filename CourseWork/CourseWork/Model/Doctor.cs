using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal class Doctor:PersonModel
    {
        public string DoctorID { get; set; }
        public string Dolzhnost { get; set; }
        public string Cabinet { get; set; }

    }
}
