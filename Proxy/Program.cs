using System;
using System.Xml.Linq;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Proxy();
            subject.Request();


            RealSubject realSubject = new RealSubject();
            realSubject.Request();
        }
    }

    internal class Subject
    {
    }
}
