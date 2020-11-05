using _20201105.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20201105
{
    class CarApi
    {
        public List<Image> Getplate(string input) 
        {
            List<Image> result = new List<Image>();
            result.Add(Resources._002);
            result.Add(Resources._003);
            result.Add(Resources._004);
            result.Add(Resources._005);
            result.Add(Resources._006);


            return result;
        }
    }
}
