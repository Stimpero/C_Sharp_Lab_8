using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstruct
{
    class Program
    {   // 2.1
        public enum typeTraine { skTrain, pasTrain, tTrain };
        class Train
        {
            public string number;
            public string message;
            public int count;
            public typeTraine type;
            public Train(string num, string mes, int c, string traine)
            {
                number = num;
                message = mes;
                count = c;
                this.type = (typeTraine)Enum.Parse(typeof(typeTraine), traine);
            }
            public override string ToString()
            {
                return "Train: " + number + " " + message + " " + count + " " + type;
            }
        }
        class FirmTrain : Train
        {
            public string nameFirm;
            public int kPrice;
            public FirmTrain(string num, string mes, int c, string traine, string name, int k) : base(num, mes, c, traine)
            {
                number = num;
                message = mes;
                count = c;
                this.type = (typeTraine)Enum.Parse(typeof(typeTraine), traine);
                nameFirm = name;
                kPrice = k;
            }
            public override string ToString()
            {

                return base.ToString() + " " + nameFirm + " " + kPrice;
            }
        }
        //2 . 2
        interface IDisposable
        {
            void method();
        }




        class BigClass : IDisposable, IComparable , IConvertible
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public TypeCode GetTypeCode()
            {
                throw new NotImplementedException();
            }

            public void method()
            {
                throw new NotImplementedException();
            }

            public bool ToBoolean(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public byte ToByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public char ToChar(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public DateTime ToDateTime(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public decimal ToDecimal(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public double ToDouble(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public short ToInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public int ToInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public long ToInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public sbyte ToSByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public float ToSingle(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public string ToString(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public object ToType(Type conversionType, IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ushort ToUInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public uint ToUInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ulong ToUInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }
        }


        static void Main(string[] args)
        {
            FirmTrain a1 = new FirmTrain("a1", "Hello", 12, "skTrain", "Rails", 10);
            Console.WriteLine(a1);

            //2.4
            Int16 i16 = 2;
            Int32 i32 = 24214;
            double d = 23.451;

            //i16 = i32; //сужающие преобразование только явно.
            //i16 = d;   //сужающие преобразование только явно.

            i32 = i16; 
            //i32 = d;  //сужающие преобразование только явно.

            d = i16;
            d = i32;
        }
    }
}