using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quads : MonoBehaviour {

    public Sprite standard;
    public Sprite standard_pressed;
    public Sprite flag;
    public Sprite bomb;
    public Sprite bombExplode;
    bool isPressed = false;

    public Sprite[] arr;


    void OnMouseOver()
    {
        string links = "Linksklick";
        string rechts = "Rechtsklick";
        string beide = "Beide";

        if (Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(1))
        {
            isPressed = true;
            print(beide);
        }
        else
        {
            isPressed = false;
        }
        if (Input.GetMouseButtonDown(0) && !isPressed)
        {
            print(links);
        }
        if (Input.GetMouseButtonDown(1) && !isPressed)
        {
            print(rechts);
        }
        //this.GetComponent<SpriteRenderer>();
    }
}
