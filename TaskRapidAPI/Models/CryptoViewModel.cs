namespace TaskRapidAPI.Models
{
    public class CryptoViewModel
    {
        public int error { get; set; }
        public string message { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public string _base { get; set; }
            public int total { get; set; }
            public Token[] tokens { get; set; }
        }

        public class Token
        {
            public string symbol { get; set; }
            public string price { get; set; }
        }

    }
}
