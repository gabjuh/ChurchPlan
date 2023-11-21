using System;
using System.Text.Json;
using System.Diagnostics;

namespace ChurchPlan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static string GetPlainText()
        {
            string fileName = @"..\..\..\res\data.txt";

            StreamReader streamReader = new StreamReader(fileName);

            string text = streamReader.ReadToEnd();

            streamReader.Close();

            return text;
        }

        public static string GetJsonAsText()
        {
            string fileName = @"..\..\..\res\data.json";

            StreamReader streamReader = new StreamReader(fileName);

            string text = streamReader.ReadToEnd();

            streamReader.Close();

            return text;
        }
    }
}