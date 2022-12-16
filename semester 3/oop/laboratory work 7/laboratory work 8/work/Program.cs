using lab8;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;


TestTextReader();
TestTextWriter();


 void TestTextWriter()
{
    string path = "TextFile_TextWriter.txt";
    using (StreamWriter sw = new StreamWriter(path))
    {
        TextWriter writer = new TextWriterDate(new TextWriterNumberLine(sw));
        writer.WriteLine("test 1");
        writer.WriteLine("test 2");
        writer.WriteLine("test 3");
        writer.WriteLine("test 4");
    }
}
void TestTextReader()
{
    string path = "TextFile_TextReader.txt";
    TextReader reader = new TextReaderDate(new TextReaderNumberLine(new TextReaderLowerCase(new StreamReader(path, System.Text.Encoding.Default))));
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}