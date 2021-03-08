using System; 
using System.Threading;
namespace VSCODECSHARP{
    public class TimeEventArgs : EventArgs {
        public TimeEventArgs(DateTime t) {
            DateTimeNow = t;
        }

        public DateTime DateTimeNow {get;set;}
    }
    public class Clock{
        public delegate void SecondHandler(object o , TimeEventArgs e );
        public event SecondHandler OnSecondChange;
        public void Run()
        {
            while (true) {
            //sleep  seconds
            Thread.Sleep(100);
            if (OnSecondChange != null)
            {
                OnSecondChange(new object(), new TimeEventArgs (DateTime.Now)); 
            }
            }
        }
    }
}
