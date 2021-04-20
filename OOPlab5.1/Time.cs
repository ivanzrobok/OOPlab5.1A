using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab5._1
{
    public class Time
    {
        public Time() { }
        public Time(int first, int second)
        {
            if (first > 24 || second > 60) throw new InvalidTimeZoneException("first>24 || second>60 !!!");
            this.first = first;
            this.second = second;
        }
        public Time(Time time)
        {
            if (time.first > 24 || time.second > 60) throw new InvalidTimeZoneException("first>24 || second>60 !!!");
            this.first = time.first;
            this.second = time.second;
        }

        private int first;
        private int second;
        public float Minutes()
        {
            return first * 60 + second;
        }
        public void Input()
        {
            string firstText, secondText;

            Console.WriteLine("Введіть перше число: ");
            firstText = Console.ReadLine();

            Console.WriteLine("Введіть друге число: ");
            secondText = Console.ReadLine();

            int firstCount;
            int secondCount;
            if (!int.TryParse(firstText, out firstCount))throw new InvalidCastException("Ви ввели строку");
            if (!int.TryParse(secondText, out secondCount))throw new InvalidCastException("Ви ввели строку");

            this.first = firstCount;
            this.second = secondCount;
            //bool Isdigit1 = first.Length == first.Where(c => char.IsDigit(c)).Count();
            //bool Isdigit2 = second.Length == second.Where(c => char.IsDigit(c)).Count();

            /*if (Isdigit1 && Isdigit2)
            {
                this.first = Convert.ToInt32(first);
                this.second = Convert.ToInt32(second);
                Console.WriteLine("Ви ввели правильні числа");
            }
            else Console.WriteLine("Числа неправильні");*/
        }
        public void Display()
        {         
            Console.WriteLine($"Кількість хвилин в {this.first} год. i {this.second} хв. = {Minutes()} хв.");
        }
    }
}
