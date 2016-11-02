using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public Color DefaultColor;
    public Color SelectedColor;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void OnTouchDown()
    {
        mat.color = SelectedColor;
    }
    void OnTouchUp()
    {
        mat.color = DefaultColor;
    }
    void OnTouchStay()
    {
        mat.color = SelectedColor;
    }
    void OnTouchExit()
    {
        mat.color = DefaultColor;
    }
}
