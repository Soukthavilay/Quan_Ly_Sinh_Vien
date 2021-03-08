using System;

namespace VSCODECSHARP
{
    public interface IFile1
    {
        void A();
        void B();
    }

    public interface IFile2
    {
        void C();
        void A();
    }

    public class MyClass : IFile1, IFile2
    {
        public void A()
        {
            Console.WriteLine("A1");
        }

        public void B()
        {
            Console.WriteLine("B1");
        }

        public void C()
        {
            Console.WriteLine("C1");
        }

        public void D()
        {
            Console.WriteLine("D1");
        }
    }
}