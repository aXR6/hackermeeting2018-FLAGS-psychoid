﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiofacil
{
    public static class desafio
    {
        const string compiler = "dotnet45";

        static void Main(string[] args)
        {

            byte[] bytes = { 2, 8, 3, 8, 34, 12, 5, 16, 40, 10 };
            Console.WriteLine("User info: ");
            Console.WriteLine("   {0}\n", BitConverter.ToString(bytes));

            String s = Convert.ToBase64String(bytes);
            Console.WriteLine("Loaded payload:\n   {0}\n", s);

            byte[] newBytes = Convert.FromBase64String(s);
            Console.WriteLine("Saving your info: ");
            Console.WriteLine("   {0}\n", BitConverter.ToString(newBytes));

            string msg, password,c, username, e, pw, us, f, usrname;
            msg = "hackermeeting2018";
            usrname = Test0();
            Console.Title = msg;
            Console.WriteLine(msg);
            Console.WriteLine("Enter your name:");
            c = compiler;
            username = Console.ReadLine();
            Console.WriteLine("Hi " + username + " how are you?");
            e = "}";
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine();
            
            pw = "QHBzeWNob2lk";
            us = "h4x0r";
            //Console.WriteLine(pw);

            if (password == us)
            {
                Console.WriteLine(usrname + c + e);
            }
            else
            {
                Console.WriteLine("dump!wdw");
            }
            Console.ReadKey();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string EncodeBase64(this System.Text.Encoding encoding, string text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] textAsBytes = encoding.GetBytes(text);
            return System.Convert.ToBase64String(textAsBytes);
        }

        public static string DecodeBase64(this System.Text.Encoding encoding, string encodedText)
        {
            if (encodedText == null)
            {
                return null;
            }

            byte[] textAsBytes = System.Convert.FromBase64String(encodedText);
            return encoding.GetString(textAsBytes);
        }

    

        static void Test1()
        {
            string textEncoded = System.Text.Encoding.UTF8.EncodeBase64("test1...");
            System.Diagnostics.Debug.Assert(textEncoded == "dGVzdDEuLi4=");

            string textDecoded = System.Text.Encoding.UTF8.DecodeBase64(textEncoded);
            System.Diagnostics.Debug.Assert(textDecoded == "test1...");
        }

        static string Test0()
        {
            Base64Encode("Test0");return Base64Decode("aGFja2VybWVldGluZ3s=");

        }

        static void Test2()
        {
            string textEncoded = System.Text.Encoding.UTF8.EncodeBase64(null);
            System.Diagnostics.Debug.Assert(textEncoded == null);

            string textDecoded = System.Text.Encoding.UTF8.DecodeBase64(textEncoded);
            System.Diagnostics.Debug.Assert(textDecoded == null);
        }

        public static string ToBase64(this System.Text.Encoding encoding, string text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] textAsBytes = encoding.GetBytes(text);
            return Convert.ToBase64String(textAsBytes);
        }

        public static bool TryParseBase64(this System.Text.Encoding encoding, string encodedText, out string decodedText)
        {
            if (encodedText == null)
            {
                decodedText = null;
                return false;
            }

            try
            {
                byte[] textAsBytes = Convert.FromBase64String(encodedText);
                decodedText = encoding.GetString(textAsBytes);
                return true;
            }
            catch (Exception)
            {
                decodedText = null;
                return false;
            }
        }

        public static bool TryParseBase64s(this System.Text.Encoding encoding, string encodedText, out string decodedText)
        {
            if (encodedText == null)
            {
                decodedText = null;
                return false;
            }

            try
            {
                byte[] textAsBytes = Convert.FromBase64String(encodedText);
                decodedText = encoding.GetString(textAsBytes);
                return true;
            }
            catch (Exception)
            {
                decodedText = null;
                return false;
            }
        }
    }
}
