using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

    public Sprite standardPlane;
    public Sprite flagPlane;

    void Start()
    {
        MouseClickRight();
    }

	void OnMouseDown () {
        Destroy(gameObject);
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
