using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226001CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car DennisCar= new Car();
            //設定DennisCar的屬性值.
            DennisCar.Id = 1;
            DennisCar.Owner = "Dennis";
            DennisCar.Name = "Hello";
            //類堆..所有屬性都要設.s

            //最後,叫用DennisCar的方法PrintAllAttrib( )印出所有屬性參數.
            DennisCar.PrintAllAttrib();

            //===============================================
            //第二個 使用有參數的建構子設一台車MarysCar.
            //經由建構子函式2 來設定所有屬性
            Car MarysCar = new Car(2, "Mary", "紅色跑車", 100000, "法拉利", "446", 50000);

            //最後,叫用 MarysCar的方法PrintAllAttrib( )印出所有屬性參數.
            MarysCar.PrintAllAttrib();


        }
    }
}
