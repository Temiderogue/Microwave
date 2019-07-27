using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave
{
    class Microwave
    {
        public int Power = 0;
        public int Time = 0;

        public void ChoosePower()
        {
            Console.WriteLine("Выберите мощность:\n1.200\n2.400\n3.600\n4.800\n");

            string NumPow = Console.ReadLine();
            switch (NumPow)
            {
                case "1":
                    Power = 200;
                    break;
                case "2":
                    Power = 400;
                    break;
                case "3":
                    Power = 600;
                    break;
                case "4":
                    Power = 800;
                    break;
            }
        }

        public void ChooseTime()
        {
            Console.WriteLine("Выберите время:\n1.5 минут\n2.10 минут\n3.15 минут\n");
            string NumTime = Console.ReadLine();
            switch (NumTime)
            {
                case "1":
                    Time = 5;
                    break;
                case "2":
                    Time = 10;
                    break;
                case "3":
                    Time = 15;
                    break;
            }
        }

        public void Start()
        {
            Console.WriteLine($"СВЧ начала свою работу и через {Time} минут ваша еда будет разогрета.") ;
        }
    }
}
