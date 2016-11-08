using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

    public  static string vehicle;
    // Use this for initialization
   

    void Start () {
        DontDestroyOnLoad(this);
	}

	
	// Update is called once per frame
	void Update () {
        var farve= GetComponent<Renderer>();

        if (vehicle == "patient bus")
        {
            farve.material.color = Color.blue;
        }
        if (vehicle == "fejeblad")
        {
            farve.material.color = Color.green;
        }
        if (vehicle == "el truck")
        {
            farve.material.color = Color.red;
        }
        if (vehicle == "Senge transport")
        {
            farve.material.color = Color.yellow;
        }
    }

    
}
