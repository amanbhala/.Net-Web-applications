using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Question1_2_3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Function to convert Celsius to Farhenheit
        public int CelsiusToFahrenheit(int celsius)
        {
            return ((celsius * 9 / 5) + 32);
        }

        // Function to convert Farhenheit to Celsius
        public int FahrenheitToCelsius(int fahrenheit)
        {
            return ((fahrenheit - 32) * 5) / 9;
        }

        //Function to sort numbers
        public string SortNumbers(string s)
        {
            // Splitting the string using ',' as a delimiter
            string[] words = s.Split(',');
            // Creating a new Integer array to convert string to integers
            int[] values = words.Select(int.Parse).ToArray();
            int i = 0;
            foreach (string word in words)
            {
                values[i] = int.Parse(word);
                i++;
            }
            // Sorting the integer array
            Array.Sort(values);
            // Joining the elements in the array to create sorted string
            string sortedstring = string.Join(",", values);
            return sortedstring;
        }
    }
}
