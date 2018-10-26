using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter.Business
{
    public class ClassLibrary
    {
        public int ConvertCtoF(int TempC)
        {
            return ((9 / 5) * TempC) + 32;
        }
        public int ConvertFtoC(int TempF)
        {
            return (TempF - 32) * 5 / 9;
        }
    }
}
