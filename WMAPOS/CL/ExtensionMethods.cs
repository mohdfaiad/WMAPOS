using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Configuration
{
    public static class ExtensionMethods
    {
        #region Members
        private static byte[] _key = { };
        private static readonly byte[] Iv = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xab, 0xcd, 0xef };
        #endregion
        #region Methods
        public static string FormatString(this string str, params object[] p)
        {
            return string.Format(str, p);
        }

        public static string[] Split(this string str, char p)
        {
            return str.Split(new[] { p });
        }
        public static string[] Split(this string str, string p)
        {
            return str.Split(new[] { p }, StringSplitOptions.None);
        }
        public static string IsNull(this object o, string returnvalue = "")
        {
            return o == null || o == DBNull.Value ? returnvalue : o.ToString();
        }

        public static string AdjustInCond(this string o, string returnvalue = "")
        {
            return o.Split(',').Select(s => "'" + s + "'").ToArray().Join(",");
        }
        public static string AdjustInCondForSP(this string o, string returnvalue = "")
        {
            return "'" + o.Split(',').ToArray().Join(",") + "'";
        }

        public static Guid ToGuid(this string o)
        {
            return Guid.Parse(o);
        }

        /// <summary>
        /// لأاختبار القيمة المدخلة فى المتغير 
        /// </summary>
        /// <param name="value">نص</param>
        /// <returns>true/false</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string Join(this IEnumerable<string> value, string separate)
        {
            return string.Join(separate, value);
        }

        public static T Cast<T>(this object o) where T : class
        {
            return o as T;
        }


        #endregion
        #region Serialize DeSerialize Object
        public static string Serialize(this object obj)
        {
            var jsonSerializer = new DataContractJsonSerializer(obj.GetType());
            string returnValue = "";
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(memoryStream))
                {
                    jsonSerializer.WriteObject(writer, obj);
                    writer.Flush();
                    returnValue = Encoding.UTF8.GetString(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
                }
            }
            return returnValue;
        }
        public static T Deserialize<T>(this string json)
        {
            T returnValue;
            using (var memoryStream = new MemoryStream())
            {
                var settings = new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-dd HH:mm:ssZ") // Use this because Json object for date
                };
                byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
                memoryStream.Write(jsonBytes, 0, jsonBytes.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var jsonReader = JsonReaderWriterFactory.CreateJsonReader(memoryStream, Encoding.UTF8, XmlDictionaryReaderQuotas.Max, null))
                {
                    var serializer = new DataContractJsonSerializer(typeof(T), settings);
                    returnValue = (T)serializer.ReadObject(jsonReader);
                }
            }
            return returnValue;
        }

        public static string SerializeWithEncrypt(this object obj)
        {
            return obj.Serialize().Encrypt();
        }
        public static T DeserializeWithDecrypt<T>(this string dJson)
        {
            return dJson.Decrypt().Deserialize<T>();
        }
        #endregion
        #region Encrypt & Decrypt String
        public static string Decrypt(this string stringToDecrypt)
        {
            stringToDecrypt = stringToDecrypt.Replace(" ", "+");
            byte[] inputByteArray = new byte[stringToDecrypt.Length + 1];
            MemoryStream ms = new MemoryStream();
            try
            {
                _key = Encoding.UTF8.GetBytes("r0b1mr0y");
                var des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(stringToDecrypt);

                var cs = new CryptoStream(ms,
                    des.CreateDecryptor(_key, Iv), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                var encoding = Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                ms.Dispose();
            }
        }
        public static string Encrypt(this string stringToEncrypt)
        {
            try
            {
                _key = Encoding.UTF8.GetBytes("r0b1mr0y");
                var des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                var ms = new MemoryStream();
                var cs = new CryptoStream(ms,
                des.CreateEncryptor(_key, Iv), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        #endregion
        public static object SetValues(this object o, object f)
        {
            f.GetType().GetProperties().Select(p => p.Name).ToList().ForEach(ky =>
            {
                if (o.GetType().GetProperty(ky) != null)
                {
                    PropertyInfo p = o.GetType().GetProperty(ky);
                    object newvalue = f.GetType().GetProperty(ky).GetValue(f);
                    var val = (newvalue.IsNull() == "" || newvalue.IsNull() == "0") ? null : Convert.ChangeType(newvalue, o.GetType().GetProperty(ky).PropertyType);
                    p.SetValue(o, val, null);
                }
            });
            return o;
        }
        /// <summary>
        /// Get value by property name  
        /// </summary>
        /// <param name="obj">Source Object</param>
        /// <param name="propname">Propertyname</param>
        /// <returns></returns>
        public static object GetValue(this object obj, string propname)
        {
            return obj.GetType().GetProperty(propname).GetValue(obj, null);
        }
        public static void SetValue(this object obj, string propname, object value)
        {
            obj.GetType().GetProperty(propname).SetValue(obj, value, null);
        }

        public static List<T> CastObject<T>(this object myobj)
        {
            List<T> list = new List<T>();
            foreach (var o in (IEnumerable)myobj)
            {
                Type objectType = o.GetType();
                Type target = typeof(T);
                var x = Activator.CreateInstance(target, false);
                var z = from source in objectType.GetMembers().ToList()
                        where source.MemberType == MemberTypes.Property
                        select source;
                var d = from source in target.GetMembers().ToList()
                        where source.MemberType == MemberTypes.Property
                        select source;
                List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name)
                   .ToList().Contains(memberInfo.Name)).ToList();
                foreach (var memberInfo in members)
                {
                    var propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                    var value = o.GetType().GetProperty(memberInfo.Name)?.GetValue(o, null);

                    propertyInfo.SetValue(x, value, null);
                }
                list.Add((T)x);
            }

            return list;
        }

        /// <summary>
        /// نسخ كائن الى كائن اخر 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target">كائن الاساسى</param>
        /// <param name="source">كائن المصدر</param>
        /// <returns>كائن الاساسى بعد التعديل</returns>
        public static T CloneFrom<T>(this T target, object source)
        {
            if (target == null || source == null) throw new Exception("لا يمكن ان يكون العناصر بقيمة Null");

            foreach (var p in target.GetType().GetProperties())
            {
                 var value = source.GetValue(p.Name);
                target.SetValue(p.Name, value);
            }
            return target;
        }


        public static string GetMD5Hash(this string stringToBeHashed)
        {
            try
            {
                StringBuilder hash = new StringBuilder();
                MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
                byte[] bytes = md5Provider.ComputeHash(new UTF8Encoding().GetBytes(stringToBeHashed));

                foreach (byte t in bytes)
                {
                    hash.Append(t.ToString("x2"));
                }
                return hash.ToString();


            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

    }
}
