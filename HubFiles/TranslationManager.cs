using System.Text;
using System.Xml;

namespace HubFiles
{
    public class TranslationManager
    {
        public void AddTranslationToFile(string fileName, string translationKey, string translationText)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load(fileName);
            XmlNode element = doc.CreateNode(XmlNodeType.Element, "text", null);

            XmlAttribute key = doc.CreateAttribute("name");
            key.Value = translationKey;

            XmlAttribute text = doc.CreateAttribute("value");
            text.Value = translationText;

            element.Attributes.Append(key);
            element.Attributes.Append(text);

            doc.SelectSingleNode("//texts").AppendChild(element);

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = " ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace,
            };

            using (var writer = XmlWriter.Create(fileName, settings))
            {
                // Salve o documento usando o XmlWriter
                doc.Save(writer);
            }
        }
    }
}