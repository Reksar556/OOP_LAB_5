using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Dat
    {
       // private List<List<double>> Data_point_list = new List<List<double>>();
       // private List<double> row = new List<double>();

        private struct Data_point
        {
            private double x=0;
            private double y=0;

            private double X { get { return x; } set { x = value; } }
            private double Y { get { return y; } set { y = value; } }

            public Data_point(double x, double y)
            {

            }
        }

        private List<Data_point> Data_point_list = new List<Data_point>();

        public void Add_data_point(double x, double y)
        {
            Data_point cur = new Data_point(x,y);

            
            Data_point_list.Add(x,y)
        }

     
    }
}
