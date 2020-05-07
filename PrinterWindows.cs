using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("");
        }
        public virtual void Print()
        {
            Console.WriteLine("");
        }
    }

    class Canon : PrinterWindows
    {
        public override void Show()
        {
            base.Show();
            Console.Write("\tCanon Display dimension is 9.5 x 12");
        }
        public override void Print()
        {
            base.Print();
            Console.Write("\tCanon printer printing...");
        }
    }

    class Epson : PrinterWindows
    {
        public override void Show()
        {
            base.Show();
            Console.Write("\tEpson Display Dimension is 10 x 11");
        }
        public override void Print()
        {
            base.Print();
            Console.Write("\tEpson printer printing...");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            base.Show();
            Console.Write("\tLaser Jet Display Dimension is 12 x 12");
        }
        public override void Print()
        {
            base.Print();
            Console.Write("\tLaser Jet printer printing...");
        }
    }
}


