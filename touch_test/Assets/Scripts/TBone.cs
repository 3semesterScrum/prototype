using UnityEngine;
using System.Collections;

public class TBone : MonoBehaviour
{
    [SerializeField]
    private GameObject Car;
    [SerializeField]
    private GameObject playerVehicle;

	void Start ()
    {

	}
	
	void Update ()
    {

	}

    public void CreateTBoner()
    {
        GameObject tBoner = Instantiate(Car);
    }
}
