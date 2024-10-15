using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Class1
    {
    }
    public static class class2
    {
        public static void ShowNos()
        {
            int[] age = { 55, 22, 33, 77, 11 ,66,44,88,99};
            //var b = from i in age where i > 20 select i;
            //var c = from i in age where i > 20 orderby i select i;
            var a = from i in age where i > 20  orderby  i descending select i;      //comes from linQ
            foreach (var item in a)
            {
                Console.WriteLine( item);
            }
        }

        public static void ShowName()
        {
            string[] arr = {"Hughie", "Kimiko","Galadriel"};

            //var b = from name in arr where name.Contains("a") select name;
            var a = from name in arr where name.StartsWith("K") select name;
            
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
