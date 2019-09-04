using System;
using System.Collections.Generic;

namespace DataStructures
{
    class DictionaryTest
    {
        public static void Main()
        {
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            #region Add item
            EmployeeList.Add("Khoa", "Co tuong");
            EmployeeList.Add("Loc", "Co vua");
            EmployeeList.Add("Bao", "Karaoke");
            #endregion

            #region Show all values
            Console.WriteLine("Show all values");
            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Show all Keys
            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }
            #endregion

            #region Show all values by key
            Console.WriteLine("Show all by keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            }
            #endregion

            #region Remove item by key
            Console.WriteLine("----------------------------");
            EmployeeList.Remove("Khoa");

            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            }
            #endregion

            #region Remove item by key and return value
            Console.WriteLine("----------------------------");
            string locValue;
            EmployeeList.Remove("Loc", out locValue);
            Console.WriteLine(locValue);

            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            }
            #endregion

            #region Show all value by using enumerator
            Console.WriteLine("----------------------------");
            var enumerator = EmployeeList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("Key : {0} Value : {1}",
                                enumerator.Current.Key, enumerator.Current.Value);
            }
            #endregion
        }
    }
}
