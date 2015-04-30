using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using net.sf.jni4net;
using net.sf.jni4net.jni;
using pl.yaras.java;

namespace ConsoleApplication
{
    public class Program : IDisposable
    {
        private JNIEnv env;

        public Program()
        {
            var bridgeSetup = new BridgeSetup();
            bridgeSetup.AddAllJarsClassPath(".");
            this.env = Bridge.CreateJVM(bridgeSetup);
            Bridge.RegisterAssembly(typeof(Calc).Assembly);
        }

        public static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.Add(2, 3));
            Console.ReadKey();
        }

        public int Add(int a, int b)
        {
            return Calc.add(a, b);
        }

        public int Sub(int a, int b)
        {
            return Calc.sub(a, b);
        }        

        public void Dispose()
        {
            //this.env.GetJavaVM().DestroyJavaVM();
        }
    }
}
