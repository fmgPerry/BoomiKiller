using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Web;
using BoomiKillerAPI.Areas.GW_PC.Models;

namespace BoomiKillerAPI.Areas.GW_PC.Helper
{
    public static class Obfuscation
    {
        private static List<string> elementsToObfuscate = new List<string>() { "ID", "AccountHolderID", "ContactID", "MainDriver", "PolicyPeriodID", "FixedId", "Entry", "JobID", "ContactId", "CoverableID", "MainContact", "ReportedBy", "JobNumber", "FixedID", "SliceDate" };
        private static List<string> elementsToReverseObfuscate = new List<string>() { "ID", "FixedID", "FixedId", "JobNumber", "JobID", "MainDriver", "SliceDate" };
        private static string fmgapi_undefined = Constants.fmgapi_undefined;

        public static object Obfuscate(object thisObject)
        {
            ObfuscateObject(thisObject);
            return thisObject;
        }
        public static object ReverseObfuscate(object thisObject)
        {
            ReverseObfuscateObject(thisObject);
            return thisObject;
        }
        private static object ObfuscateObject(object thisObject)
        {
            if (thisObject != null)
            {
                if(thisObject.GetType().IsArray)
                {
                    foreach(var singleObject in thisObject as IEnumerable)
                    {
                        ObfuscateIt(singleObject);
                    }
                }
                else
                {
                    ObfuscateIt(thisObject);
                }
            }
            return thisObject;
        }

        private static void ObfuscateIt(object singleObject)
        {
            var properties = singleObject.GetType().GetProperties().ToList();
            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                if (propertyType.IsArray || propertyType.Namespace != "System")
                {
                    var result = ObfuscateObject(property.GetValue(singleObject));
                    property.SetValue(singleObject, result);
                }
                if (elementsToObfuscate.Contains(property.Name))
                {
                    // Obfuscate
                    var result = Obfuscate(property.GetValue(singleObject)?.ToString());
                    property.SetValue(singleObject, result);
                }
            }
        }

        private static object ReverseObfuscateObject(object thisObject)
        {
            if (thisObject != null)
            {
                if (thisObject.GetType().IsArray)
                {
                    foreach (var singleObject in thisObject as IEnumerable)
                    {
                        ReverseObfuscateIt(singleObject);
                    }
                }
                else
                {
                    ReverseObfuscateIt(thisObject);
                }
            }
            return thisObject;
        }

        private static void ReverseObfuscateIt(object thisObject)
        {
            var properties = thisObject.GetType().GetProperties().ToList();
            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                if (propertyType.IsArray || propertyType.Namespace != "System")
                {
                    var result = ReverseObfuscateObject(property.GetValue(thisObject));
                    property.SetValue(thisObject, result);
                }
                if (elementsToReverseObfuscate.Contains(property.Name))
                {
                    // Reverse Obfuscate
                    var result = ReverseObfuscate(property.GetValue(thisObject)?.ToString());
                    property.SetValue(thisObject, result);
                }
            }
        }

        public static string Obfuscate(string text)
        {
            if (text == fmgapi_undefined || text == null)
            {
                return text;
            }

            var encrypted = encrypt(text);
            var utf8Encoded = System.Text.Encoding.UTF8.GetBytes(encrypted);
            Array.Reverse(utf8Encoded);
            var bigInteger = new BigInteger(utf8Encoded);
            var base36Encoded = Base36.Encode(bigInteger);
            
            return base36Encoded;
        }

        public static string ReverseObfuscate(string text)
        {
            if (text == fmgapi_undefined || text == null)
            {
                return text;
            }

            var base36Decoded = Base36.Decode(text).ToByteArray();
            Array.Reverse(base36Decoded);
            var base36DecodedString = System.Text.Encoding.UTF8.GetString(base36Decoded);
            var decrypted = decrypt(base36DecodedString);

            return decrypted;
        }
        private static AesManaged CreateAes()
        {
            new SecretsReader().GetSecrets();
            var secret = Constants.secretKeyValue;

            for (var i = 0; i < 4; i++)
            {
                secret += secret;

            }
            var secretKey = secret.Substring(0, 16);

            var aes = new AesManaged();
            aes.Key = System.Text.Encoding.UTF8.GetBytes(secretKey);
            aes.IV = System.Text.Encoding.UTF8.GetBytes(secretKey);
            return aes;
        }
        public static string encrypt(string text)
        {
            using (AesManaged aes = CreateAes())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor();
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(text);
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }
        public static string decrypt(string text)
        {
            using (var aes = CreateAes())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor();
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(text)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }

            }
        }
        public static class Base36
        {
            //private const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private const string Digits = "0123456789abcdefghijklmnopqrstuvwxyz";

            public static BigInteger Decode(string value)
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Empty value.");
                //value = value.ToUpper();
                bool negative = false;
                if (value[0] == '-')
                {
                    negative = true;
                    value = value.Substring(1, value.Length - 1);
                }
                if (value.Any(c => !Digits.Contains(c)))
                    throw new ArgumentException("Invalid value: \"" + value + "\".");
                BigInteger decoded = 0L;
                for (var i = 0; i < value.Length; ++i)
                    decoded += Digits.IndexOf(value[i]) * BigInteger.Pow(Digits.Length, value.Length - i - 1);
                return negative ? decoded * -1 : decoded;
                
            }

            public static string Encode(BigInteger value)
            {
                if (value == long.MinValue)
                {
                    //hard coded value due to error when getting absolute value below: "Negating the minimum value of a twos complement number is invalid.".
                    return "-1Y2P0IJ32E8E8";
                }
                bool negative = value < 0;
                //value = Math.Abs(value);
                value = BigInteger.Abs(value);
                string encoded = string.Empty;
                do
                    encoded = Digits[(int)(value % Digits.Length)] + encoded;
                while ((value /= Digits.Length) != 0);
                return negative ? "-" + encoded : encoded;
            }
        }
    }
}