using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Analysis
    {
        public string ID { get; set; }
        public DateTime DataAnaliza{ get; set; }
        public double  Obshchiybilirybin { get; set; }
        public double Nepryamoybilirybin  { get; set; }
        public double Pryamoybilirybin { get; set; }
        public double Kholestirin { get; set; }
        public double Glukoza { get; set; }

    }
}
