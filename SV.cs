using System;

namespace VSCODECSHARP
{
    class SV
    {
        public SV(int d1, string d2, double d3)
        {
            MSSV = d1; Ten = d2; DTB = d3;
        }
        public SV() {
            
        }
        public int MSSV { get; set; }
        public string Ten { get; set; }
        public double DTB { get; set; }
        public void Show()
        {
            Console.WriteLine("MSSV = {0}, Ten = {1}, DTB = {2}", MSSV, Ten, DTB);
        }
        public override string ToString()
        {
            return String.Format("MSSV = {0}, Ten = {1}, DTB = {2}", MSSV, Ten, DTB);
        }
        public static bool CompareMSSV(object s1 , object s2){
            return (((SV)s1).MSSV > ((SV)s2).MSSV)? true : false ;
        }
        public static bool CompareString(object s1 , object s2 )
        {
            return (String.Compare(((SV)s1).Ten, ((SV)s2).Ten) > 0) ? true  : false;

        }
    }

}