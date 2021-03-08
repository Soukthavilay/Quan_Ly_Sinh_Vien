using System; 
namespace VSCODECSHARP {
    public class AnalogClock {
        public AnalogClock() { }
        public void RunAC(object o, TimeEventArgs e) {
            Console.WriteLine("AC: " + e.DateTimeNow.ToString());
        }
    }
}