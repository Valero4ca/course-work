using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal class Analysis: PersonModel
    {
        public DateTime  Analiza{ get; set; }
        public string PatientID { get; set; }
        public string Doctor { get; set; }
        public string Pocazateli { get; set; }

        public float Obshchiyanaliz { get; set; }
    public float Obshchiybilirybin { get; set; }
public float Nepryamoybilirybin  { get; set; }
public float Pryamoybilirybin{ get; set; }
public float Kholestirin { get; set; }
public float Glukoza{ get; set; }

    }
}
