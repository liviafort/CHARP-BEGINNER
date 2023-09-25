using lecture_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate
{
    internal class instance_example{
        public int method_11(){
            //call a static
            Lecture1.method_4(0, 0);

            //call a not static
            Lecture1 lecture1 = new Lecture1();
            lecture1.method_3(0, 0);
            return 0;
        }
    }
}
