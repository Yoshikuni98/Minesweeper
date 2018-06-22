using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    public int sizeH = 9;
    public int sizeW = 9;
    public Button Smiley_Normal;
    public Button Smiley_Erstaunt;
    public Button Smiley_Cool;
    public Button Smiley_Traunrig;
    public GameObject Block;

    

    void Start()
    {
    }

    void Update()
    {
        GridGen();
    }

    GameObject GridGen()
    {
        int size = sizeH * sizeW;
        GameObject[] GridBlock = new GameObject[size];
        for (int y = 0; y < sizeH; y++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position += new Vector3(0, 1, 0);
            return cube;
        }
        return null;
    }

}
