using System; 
namespace VSCODECSHARP {
    public class DigitalClock {
        public DigitalClock() { }
        public void RunDC(object o, TimeEventArgs e) {
            Console.WriteLine("DC: " + e.DateTimeNow.ToString());
        }
    }
}