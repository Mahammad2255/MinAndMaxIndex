using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class ArrayCheck
    {
        public void Check(int []arr)
        {
            
            int min;
            int max;

            min = arr[0];
            max = arr[0];
            int maxIndex = 0;
            int minIndex = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                    
                }
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                    
                }
                

            }
            Console.WriteLine("En boyuk eded: " + max + " En boyuk ededin indeksi: " + maxIndex);
            Console.WriteLine("En kicik eded: " + min+ " En kicik ededin indeksi: " +  minIndex);
            
            
        }
       
    }
}
