using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 触发事件
{
    delegate void Handler();
    //声明委托
    class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();
            Dozens dozensCounter = new Dozens(incrementer);
            incrementer.DoCount();
            Console.WriteLine("number of dozens ={0}",dozensCounter.DozensCount);
            Console.ReadKey();

        }

    }
    class Incrementer
    {
        public event Handler CountedADozen;
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%12 == 0 && CountedADozen!=null)
                {
                    CountedADozen();
                }
            }
        }
    }
    //上面的是发布者

    class Dozens
    {
        public int DozensCount { get; private set; }
        //设置成从外面只能get的属性
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += Incrementer_CountedADozen;
        }

        private void Incrementer_CountedADozen()
        {
            DozensCount++;
        }
    }




    
}
