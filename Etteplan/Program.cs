using System.Xml;
using System.Xml.Linq;

// ------------------------------------------------------------------------------------------------------------
// Din uppgift blir att hämta värdet i elementet target när attributet id är 42007 och skriv det till en fil.
// ------------------------------------------------------------------------------------------------------------


GetValue();

// Metod
static void GetValue()
{
    // Skapar ett nytt Xml dokument
    XmlDocument dokoument = new XmlDocument();

    // Laddar vägen där xml dokomuentet ligger i
    dokoument.Load(@"C:\Users\Gabri\OneDrive\Skrivbord\Etteplan\sma_gentext.xml");

    // Väljer exakt vilket element som jag vill ta fram
    XmlNodeList n = dokoument.SelectNodes("root/file/body/trans-unit[@id='42007']");
    
    // Loopar igenom alla element som finns i när id=42007
    foreach(XmlNode node in n)
    {
        // Tar fram exakt vad det finns för värde i trans-unit delen när id=42007
        Console.WriteLine(node.ChildNodes[1].InnerText);

        // Skriver över den nuvarande filen med det jag har tagit fram vilket i detta fall är (Obs!)
        File.WriteAllText(@"C:\Users\Gabri\OneDrive\Skrivbord\Etteplan\sma_gentext.xml", node.ChildNodes[1].InnerText);
    }  
}


