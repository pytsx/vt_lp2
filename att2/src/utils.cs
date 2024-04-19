namespace ATT2
{
    static class Util
    {
        public static void CreateMenu(string[] opts)
        {
            Console.WriteLine("");
            foreach (string opt in opts)
            {
                Console.WriteLine(opt);
            }
            Console.WriteLine("");
        }

        public class FormData
        {
            public Dictionary<string, string> Values { get; private set; }

            public FormData()
            {
                Values = new Dictionary<string, string>();
            }

            public void AddField(string field, string? value)
            {
                Values[field] = value != null ? value : "";
            }
            
        }

        public delegate void Callback(FormData formData);

        public static void CreateForm(string[] fields, Callback callback)
        {

            FormData formData = new();

            foreach (string field in fields)
            {
                Console.Write(field + " --> ");
                string? input = Console.ReadLine();
                formData.AddField(field, input);
            }

            callback.Invoke(formData);

        }
    }
}