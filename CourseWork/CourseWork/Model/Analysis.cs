using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Analysis
    {
        public string ID { get; set; }
        public DateTime DataAnaliza{ get; set; }
        public float Obshchiybilirybin { get; set; }
        public float Nepryamoybilirybin  { get; set; }
        public float Pryamoybilirybin{ get; set; }
        public float Kholestirin { get; set; }
        public float Glukoza{ get; set; }

    }
}
