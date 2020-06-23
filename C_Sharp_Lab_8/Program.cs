using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_8
{
    class Program
    {
        public enum typeTrain { skTrain, pasTrain, tTrain };
        struct Train
        {
            public string number;
            public string route;
            public int count;
            public readonly typeTrain type;
            public Train(string n, string r, int c, string train)
            {
                number = n;
                route = r;
                count = c;
                this.type = (typeTrain)Enum.Parse(typeof(typeTrain), train);
            }
            public override string ToString()
            {
                return "Train: " + number + " " + route + " " + count + " " + type;
            }
        }
        static void Main(string[] args)
        {
            // Часть первая
            //первое и второе
            Train a1 = new Train("a1", "Hello", 12, "skTrain");
            Console.WriteLine(a1);
            //третье задание
            bool flag = false;
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 cc = 0;
            Int64 d = 0;
            String s = "";
            Exception ex = new Exception();
            Object[] types = { a, b, c, cc, d, s, ex };
            foreach (object o in types)
            {
                Type t = o.GetType();
                flag = t.IsValueType;
                Console.WriteLine("{0} is a value type: {1}", t.FullName, flag);
            }
            // четвертое задание
            String str1 = "qwerty asdfgh zxcvbn";
            String str2 = "";
            string[] sa = str1.Split();
            Array.Sort(sa);
            foreach (string st in sa)
            {
                Console.Write("{0};", st);
            }
            Console.WriteLine();
            str2 = String.Join("", sa);
            Console.WriteLine(str2);

        }
    }
}