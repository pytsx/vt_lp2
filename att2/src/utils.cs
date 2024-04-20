namespace ATT2
{
    static class Util
    {
        public static void CreateMenu(string[] opts)
        {
            foreach (string opt in opts) Console.WriteLine(opt);
        }

        public static T? ReadValue<T>(string message) 
        {
            Console.Write(message + " ");
            string? input = Console.ReadLine();
            return (T?)Convert.ChangeType(input, typeof(T));
        }
    }
}