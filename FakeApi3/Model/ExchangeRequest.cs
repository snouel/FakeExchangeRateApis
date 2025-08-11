namespace FakeApi3.Model
{
    public class ExchangeRequest
    {
        public ExchangeData Exchange { get; set; }
    }

    public class ExchangeData
    {
        public string SourceCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public decimal Quantity { get; set; }
    }

}
