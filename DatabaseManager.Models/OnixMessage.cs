using System.Xml;

namespace DatabaseManager.Models;

public class OnixMessage
{
    public string MessageNumber { get; set; }
    public XmlDocument MessageXml { get; set; } = new();
    public DateTime Inserted { get; set; } = new();
}