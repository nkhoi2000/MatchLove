using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLove
{
   class Random
    {
        public List<int> boys = new List<int>();
        public List<int> girls = new List<int>();
        public List<string> results = new List<string>();
        public void createBoysArray()
        {
            
            List<int> list = new List<int>();
            for (int i = 1; i <= 25; i++)
            {
                list.Add(i);
            }
            boys = list;
        }
        public void crearteGirlsArray()
        {
            List<int> list = new List<int>();
            for (int i = 26; i <= 50; i++)
            {
                list.Add(i);
            }
            girls = list;

        }
        public int random(List<int> list)
        {
            int temp = 0;
            System.Random rand = new System.Random();   
            temp = list[rand.Next(0, list.Count-1)];
            return temp;
        }

        public void removeRandom(List<int> list, int random)
        {
            list.Remove(random);
        }

        public bool findNumb(List<int> list, int number)
        {
            if (list.Contains(number))
            {
                return true;
            }
            return false;
        }

        public void outcome(int firstNumb, int secondNumb)
        {
            string tempStr = "" + firstNumb + " დ " + secondNumb + "\n";
            results.Add(tempStr);
        }
        
        public void removeAll()
        {
            girls.Clear();
            boys.Clear();
            results.Clear();
        }
    }
}
