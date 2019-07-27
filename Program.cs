using System;

namespace Microwave
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.ChoosePower();
            microwave.ChooseTime();
            microwave.Start();
        }
    }
}
