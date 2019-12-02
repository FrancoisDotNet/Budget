namespace Budget.Pages
{
    public class Transaction
    {
        public bool IsIncome { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int LastMonth { get; set; }
        public int ThisMonth { get; set; }
        public bool IsDone { get; set; }
    }
}