using System.Xml.Serialization;

namespace FakeApi2.Models
{
    [XmlRoot("XML")]
    public class XmlRequest
    {
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
