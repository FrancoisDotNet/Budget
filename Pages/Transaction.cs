namespace Budget.Pages
{
    public class Transaction
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public int LastMonth { get; set; }
        public int ThisMonth { get; set; }
        public bool IsDone { get; set; }
    }
}