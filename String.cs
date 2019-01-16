using System;



    public class Program
    {
      public  static void Main(string[] args)
        {
            string testValue = "123345789";

            //will print true
            Console.WriteLine(testValue.ContainsAny("023", "987", "554")); 

            //but so will this also print true
            Console.WriteLine(testValue.ContainsAny("1", "987", "554"));
           

        }
    }

    public static class StringExtensions
    {
        public static bool ContainsAny(this string str, params string[] values)
        {
            if (!string.IsNullOrEmpty(str) || values.Length > 0)
            {
                foreach (string value in values)
                {
                    if(str.Contains(value))
                        return true;
                }
            }

            return false;
        }
    
}
