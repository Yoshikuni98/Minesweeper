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
    public GameObject cube;
    public GameObject plane;
    

    void Start()
    {
        GridGen();
    }

    void Update()
    {
    }

    GameObject GridGen()
    {
        for (int y = 0; y < sizeH; y++)
        {
            for (int x = 0; x < sizeW; x++)
            {
                GameObject cubes = Instantiate(cube);
                cubes.transform.position += new Vector3(x, y, 0);
                //Debug.Log("Block");
            }
        }
        for (int y = 0; y < sizeH; y++)
        {
            for (int x = 0; x < sizeW; x++)
            {
                GameObject planes = Instantiate(plane);
                planes.transform.position += new Vector3(x, y, -1);
                //Debug.Log("Block");
            }
        }
        return null;
    }

}
