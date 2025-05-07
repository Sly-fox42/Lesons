using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Point
    {
      private  int x;
      private  int y;
      private int z;
      public Color color;

        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White,
            Orange,
            Gray,
            Gold,
            Silver
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int x,int y,int z):this(x,y) 
        {
            
            this.z=z;
        }
        public Point()
        {
            
        }
        public void Print() 
        {
            Console.WriteLine($"X: {x}\t Y: {y}");
        }
    }
}
