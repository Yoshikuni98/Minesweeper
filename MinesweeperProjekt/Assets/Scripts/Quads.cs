using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quads : MonoBehaviour
{

    public Sprite standard;
    public Sprite pressed;
    public Sprite flag;
    public Sprite bomb;
    public Sprite bombExplode;
    public Sprite[] quadNumbers;
    [SerializeField]
    bool Pressed = false;

    void Start()
    {

    }

    void OnMouseOver()
    {
        string links = "Linksklick";
        string rechts = "Rechtsklick";
        string beide = "Beide";
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2) && !Pressed)
        {
            print(Pressed);
            spriteRenderer.sprite = pressed;
            Pressed = true;
        }
        else
        {
            spriteRenderer.sprite = standard;
            Pressed = false;
        }
        if (Input.GetMouseButtonUp(0) && Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
        {
            print(beide);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            print(links);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            print(rechts);
        }

    }
}
