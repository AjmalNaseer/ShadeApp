using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadeMobileApp.Model
{
    public class DataModel
    {
        public string Month { get; set; }

        public double Target { get; set; }

        public DataModel(string xValue, double yValue)
        {
            Month = xValue;
            Target = yValue;
        }
    }
}
