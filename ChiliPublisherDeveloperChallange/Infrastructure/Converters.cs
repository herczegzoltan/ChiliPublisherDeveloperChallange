using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class Converters
    {

        //TODO generic
        //public static int GenericToIntWithRound<T>(T value)
        //{
        //    if (value.GetType() == typeof(double))
        //    {
        //        return (int)Math.Round(value, 0);
        //    }
        //    if (typeof(T) == typeof(string))
        //    {
        //        return (int)Math.Round(Convert.ToDouble(value), 0);
        //    }
        //    //return (int)Math.Round(Convert.ToDouble(inputValue), 0);
        //}

        public static int DoubleStringToIntWithRound(string value)
        {
            return (int)Math.Round(Convert.ToDouble(value), 0);
        }
        public static int DoubleToIntWithRound(double value)
        {
            return (int)Math.Round(value, 0);
        }
    }
}
