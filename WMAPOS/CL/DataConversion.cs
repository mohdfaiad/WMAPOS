using System;
using System.Text;

namespace Configuration
{
    public static class DataConversion
    {

        public static T ConvertValue<T>(this object o, string returnvalue = "") where T : IConvertible
        {
            return (T)Convert.ChangeType(o.IsNull(returnvalue), typeof(T));
        }

        /// <summary>
        /// ميثود بتاخد نص 
        /// ترجعة Enum
        /// فى حالة احتمالية وجود القيمة غير موجوده يجب اعطاء 
        /// قيمة افتراضية
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string o,string defaultValue="")
        {
            if (o.IsNull() == "") o = defaultValue;
            return (T)Enum.Parse(typeof(T), o);
        }

        public static int ToInt(this object o, int returnvalue = 0)
        {
            if (o is Enum)
            {
                return (int) o;
            }
            int value;
            return int.TryParse(o.IsNull(), out value) ? int.Parse(o.IsNull()) : returnvalue;
        }

        public static bool Toboolean(this object o, bool returnvalue = false)
        {
            if (o.IsNull().Contains("true"))
            {
                return true;
            }
            bool value;
            return bool.TryParse(o.IsNull(), out value) ? bool.Parse(o.IsNull()) : returnvalue;
        }


        /// <summary>
        /// التحويل الى Double 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="returnvalue"></param>
        /// <returns></returns>
        public static double ToDouble(this object o, double returnvalue = 0)
        {
            double value;
            return double.TryParse(o.IsNull(), out value) ? double.Parse(o.IsNull()) : returnvalue;
        }
        public static decimal ToDecimal(this object o, decimal returnvalue = 0)
        {
            decimal value;
            return decimal.TryParse(o.IsNull(), out value) ? decimal.Parse(o.IsNull()) : returnvalue;
        }
        public static double ToAbs(this double value)
        {
            return Math.Abs(value);
        }
        public static float ToAbs(this float value)
        {
            return Math.Abs(value);
        }
        public static decimal ToAbs(this decimal value)
        {
            return Math.Abs(value);
        }
        public static int ToAbs(this int value)
        {
            return Math.Abs(value);
        }
        public static long ToAbs(this long value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// تحويل الاوبجيكت الى تاريخ وفى حالة حدوث فشل يقوم بارجاع null
        /// </summary>
        /// <param name="o"></param>
        /// <returns> DateTime Or null</returns>
        public static DateTime? ToDateTime(this object o)
        {
            DateTime value;
            return DateTime.TryParse(o.IsNull(), out value) ? DateTime.Parse(o.IsNull()) : (DateTime?)null;
        }

        public static bool IsDateTime(this object o)
        {
            DateTime dateTime;
            return DateTime.TryParse(o.IsNull(), out dateTime);
        }
        public static bool IsInt(this object o)
        {
            int y;
            return int.TryParse(o.IsNull(), out y);
        }
        public static bool IsDouble(this object o)
        {
            double y;
            return double.TryParse(o.IsNull(), out y);
        }
        /// <summary>
        /// تقوم بعملة تقريب الارقام لاقرب رقم عشرى والقيمه الافتراضية 2 عشرى
        /// </summary>
        /// <param name="o"></param>
        /// <param name="frac">التقريب لاقرب</param>
        /// <returns>رقم مقرب </returns>
        public static double RoundTo(this double? o, int frac = 2)
        {
            return Math.Round(o.ToDouble(), frac);
        }
        public static decimal RoundTo(this decimal? o, int frac = 2)
        {
            return Math.Round(o.ToDecimal(), frac);
        }

        public static double RoundTo(this double o, int frac = 2)
        {
            return Math.Round(o.ToDouble(), frac);
        }
        public static decimal RoundTo(this decimal o, int frac = 2)
        {
            return Math.Round(o.ToDecimal(), frac);
        }


        public static string Encode(this string plainText)
        {
            try
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                plainText = Convert.ToBase64String(plainTextBytes);
                return plainText;
            }
            catch
            {
                return plainText;
            }
        }

        public static string Decode(this string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
                base64EncodedData = Encoding.UTF8.GetString(base64EncodedBytes);
                return base64EncodedData;
            }
            catch
            {
                return base64EncodedData;
            }

        }



       


    }
}
