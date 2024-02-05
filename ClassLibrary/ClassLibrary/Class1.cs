using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_1
{
    public class KI3_Class_1
    {
        public int F1(int x,int y)
        {
            return 3*x+y;
        }
    }
}
namespace Library_2
{
    public static class KI3_Class_2
    {
        public static int F2(int x, int y)
        {
            return x+2*y;
        }
    }
}

namespace Library_3
{
    public class KI3_Class_3 : Library_1.KI3_Class_1
    {
        public int F3(int x, int y)
        {
            return 4 * this.F1(x, y)-Library_2.KI3_Class_2.F2(x,y);
        }
    }
}

namespace Library_4
{
    public static class KI3_Class_4
    {
        public static int F4(int x, int y)
        {
            return 5*Library_2.KI3_Class_2.F2(x,y)-3;
        }
    }
}