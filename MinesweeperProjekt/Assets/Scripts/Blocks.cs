using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

    public Sprite standardBlock;
    public Sprite flagPlane;
    public Sprite bombSprite;
    public Sprite bombSpriteExplode;

    void Start()
    {
        MouseClickRight();
    }

	void OnMouseDown () {
        this.GetComponent<SpriteRenderer>();
    }

    void MouseClickRight()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
        }
        else
        {
            
        }
    }
}
