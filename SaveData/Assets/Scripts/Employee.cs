using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

[XmlRoot("Employee")]
public class Employee : GenericXmlSerialization<Employee>
{
    // Value types.
    [XmlElement("name")] public string name;
    [XmlElement("age")] public int age;

    /// <summary>
    /// Basic constructor with standart values.
    /// </summary>
    public Employee()
    {
        name = "John Doe";
        age = 18;
    }

    /// <summary>
    /// Basic constructor with exchange from name and age.
    /// </summary>
    /// <param name="name">Name from employee.</param>
    /// <param name="age">Age from employee.</param>
    public Employee(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    /// <summary>
    /// Basic function to save the values in XML file.
    /// </summary>
    public void Save()
    {
        // Declare variables.
        string filename = Application.dataPath + "/Data/" + name + ".xml";

        Save(filename);
    }
}