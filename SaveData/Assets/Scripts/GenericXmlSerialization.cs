using System.IO;
using System.Text;
using System.Xml.Serialization;

public abstract class GenericXmlSerialization<T> where T : class
{
    /// <summary>
    /// Basic function with overloading to save values in XML file.
    /// </summary>
    /// <param name="filename">Change the name of file.</param>
    public void Save(string filename)
    {
        // Declare variables.
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        using (StreamWriter stream = new StreamWriter(filename, false, Encoding.GetEncoding("UTF-8")))
        {
            serializer.Serialize(stream, this);
        }
    }

    /// <summary>
    /// Loading file.
    /// </summary>
    /// <param name="filename">Name of the loading file.</param>
    /// <returns>The data from the loading file.</returns>
    public static T Load(string filename)
    {
        // Declare variables.
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        T data;

        using (StreamReader stream = new StreamReader(filename, Encoding.GetEncoding("UTF-8")))
        {
            data = serializer.Deserialize(stream) as T;

            return data;
        }
    }
}