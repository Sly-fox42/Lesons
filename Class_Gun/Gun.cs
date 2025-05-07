using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Class_Gun
{
    internal class Gun
    {
        public Gun(bool isloaded)
        {
            this.isloaded = isloaded;
        }
        private bool isloaded;

        private void Reload()
        {
            
            Console.WriteLine("Заряжаю...");
            isloaded = true;
            Console.WriteLine("Заряжено");
        }
        public void Shoot()
        {
            if (!isloaded)
            {
                Console.WriteLine("Орудие не заряжено");
                Reload();
                Console.WriteLine("Пыщ-пыщ");
            }
            else 
            {
                Console.WriteLine("Пыщ-пыщ");
            }
        }
    }
}
