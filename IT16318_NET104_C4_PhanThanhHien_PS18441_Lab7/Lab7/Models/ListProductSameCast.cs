using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public static class ListProductSameCast
    {
       public static List<Products> list = new List<Products>();

        public static void RemoveItemsinList(List<Products> listProc)
        {
            listProc.Clear();
        }
    }
}
