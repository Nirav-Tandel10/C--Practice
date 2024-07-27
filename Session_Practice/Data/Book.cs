namespace Session_Practice.Data
{
    public class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int NumOfpage { get; set; }

        public int PriceID { get; set; }
        public Price Price { get; set; }

    }
}
