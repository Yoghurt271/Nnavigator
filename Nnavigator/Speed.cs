using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nnavigator
{
    public class Speed
    {
        public void Start(int km)
        {   Random random = new Random();
            int speed = 0;
            int p = 0;
            int t = 0;
            int time;
            int r;
            for (int i = km * 1000; i > 0; i = i - r)
            {
                speed = speed + random.Next(5) + 1;
                p = p + speed;
                t++;
                r = (int)(speed * 0.28);
                time = (int)(i / speed);
                Console.WriteLine("Текущая скорость: " + speed + " км/ч");
                Console.WriteLine("Осталось ехать: " + i / 1000 + " км");
                Console.WriteLine("Времени до прибытия: " + time + " c");
                Console.WriteLine();
                try
                {
                    Thread.Sleep(300);
                }
                catch { }

            }
        }
    }
}
