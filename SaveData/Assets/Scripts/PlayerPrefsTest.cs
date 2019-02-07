using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
	// Use this for initialization
	void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
        // By pressing return, then increment the variable.
        if (Input.GetKeyDown(KeyCode.Return))
            PersistentNumber++;
	}

    /// <summary>
    /// Output the number of clicks.
    /// </summary>
    private void OnGUI()
    {
        // Output the variable.
        GUILayout.Label("Persistent number: " + PersistentNumber);
    }

    /// <summary>
    /// Save the number of clicks.
    /// </summary>
    private int PersistentNumber
    {
        get
        {
            return PlayerPrefs.GetInt("MyPersistentNumber");
        }
        set
        {
            PlayerPrefs.SetInt("MyPersistentNumber", value);
        }
    }
}