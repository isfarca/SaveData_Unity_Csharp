using UnityEngine;

public class XmlTest : MonoBehaviour
{
	// Use this for initialization
	void Start()
    {
        // Declare variables.
        //string filename = Application.dataPath + "/Data/Hans.xml";
        //Employee hans = new Employee("Hans", 50);
        //Employee wurst = Employee.Load(filename);
        EmpInfo empInfo = new EmpInfo();

        // Testing.
        //hans.Save();

        //Debug.LogFormat("Name: {0}, Age: {1}", wurst.name, wurst.age);

        for (int i = 0; i < 10; i++)
            empInfo.employees.Add(new Employee());
        empInfo.Save();
	}
}