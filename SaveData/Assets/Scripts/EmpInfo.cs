using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[XmlRoot("empinfo")]
public class EmpInfo : GenericXmlSerialization<EmpInfo>
{
    // Reference types.
    [XmlArray("employees"), XmlArrayItem("employee")] public List<Employee> employees;

    /// <summary>
    /// Basic constructor with standart values.
    /// </summary>
    public EmpInfo()
    {
        employees = new List<Employee>();
    }

    /// <summary>
    /// Basic function to save the values in XML file.
    /// </summary>
    public void Save()
    {
        // Declare variables.
        string filename = Application.dataPath + "/Data/EmpInfo.xml";

        Save(filename);
    }
}