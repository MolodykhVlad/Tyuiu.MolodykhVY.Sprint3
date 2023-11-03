using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodykhVY.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {

        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            replaceable = 'x';
            replacement = '2';
            foreach (char repleceable in value)
            {
                if (replaceable == 'x')
                {
                    value = value.Replace('x', '2');
                }
            }
            return value;
        }
    }
}
