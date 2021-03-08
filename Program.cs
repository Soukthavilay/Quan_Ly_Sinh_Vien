using System;
using System.Collections.Generic;

namespace VSCODECSHARP
{
    class Program
    {
        public delegate bool Compare(object  s1, object s2);

        static void Sort(object[] arr, Compare cmp) {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i+1; j < arr.Length; j++) {
                    if (cmp(arr[i], arr[j])) {
                        object temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        
        }  

        
    
        static void Main(string[] args)
        {
            List<SV> l = new List<SV>();
            SV s1 = new SV{MSSV = 101, Ten = "NVA"};
            SV s2 = new SV{MSSV = 102, Ten = "NVB"};
            SV s3 = new SV{MSSV = 103, Ten = "NVC"};
            l.Add(s1);
            l.AddRange(new SV[] {s2, s3});
            int index = l.IndexOf(s2);

            // Clock c = new Clock();
            // AnalogClock c1 = new AnalogClock();
            // DigitalClock c2 = new DigitalClock();
            // c.OnSecondChange += new Clock.SecondHandler(c1.RunAC);
            // c.OnSecondChange += new Clock.SecondHandler(c2.RunDC);
            // c.Run();

            // SV[] arr = new SV[]
            // {
            //     new SV{MSSV = 102191393, Ten = "Que Son Tung"},
            //     new SV{MSSV = 102190395, Ten = "Bouphaphan Soukthavilay"},
            //     new SV{MSSV = 102130937, Ten = "Nguyen Thanh Than"},
            // };
            // Sort(arr,SV.CompareMSSV);
            // foreach(SV i in arr){
            //     Console.WriteLine(i.ToString());
            // }
        } 
    }

}
