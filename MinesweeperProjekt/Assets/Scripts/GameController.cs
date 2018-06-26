using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public int sizeH = 9;
    public int sizeW = 9;
    public Camera maincamera;
    public GameObject quad;
    float cameraZ;
    

    void Start()
    {
        GridGen();
    }

    void Update()
    {
    }

    void GridGen()
    {
        int counter = 0;
        for (int y = 0; y < sizeH; y++)
        {
            for (int x = 0; x < sizeW; x++)
            {
                GameObject quads = Instantiate(quad);
                quads.transform.position += new Vector3(x, y, -0.55f);
                quads.transform.SetParent(transform);
                counter++;
            }
        }
        Debug.Log("Quads: " + counter);

        float cameraX = sizeW / 2;
        float cameraY = sizeH / 2;
        if (sizeH <= sizeW)
        {
            float cameraZ = sizeW;
        }

        //16x16 Feld - Position muss Coordinate (7.5, 7.5, -28) haben
        //15x15 Feld - Position muss Coordinate (7, 7, -26) haben
        //14x14 Feld - Position muss Coordinate (6.5, 6.5, -24.5) haben
        //Problem nur bei Gerade Feldern
        //ungerade genau in Mitte       z achse nicht richtig

        maincamera.transform.position = new Vector3(cameraX,cameraY,maincamera.transform.position.z);
        maincamera.orthographicSize = 7;
    }

    

}
