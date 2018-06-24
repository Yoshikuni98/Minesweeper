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
    public Camera maincamera;
    

    void Start()
    {
        GridGen();
        
    }

    void Update()
    {
    }

    void GridGen()
    {
        for (int y = 0; y < sizeH; y++)
        {
            for (int x = 0; x < sizeW; x++)
            {
                GameObject cubes = Instantiate(cube);
                cubes.transform.position += new Vector3(x, y, 0);
                cubes.transform.SetParent(transform);
            }
        }
        for (int y = 0; y < sizeH; y++)
        {
            for (int x = 0; x < sizeW; x++)
            {
                GameObject planes = Instantiate(plane);
                planes.transform.position += new Vector3(x, y, -0.5f);
                planes.transform.SetParent(transform);
            }
        }

        float cameraX = sizeW / 2;
        float cameraY = sizeH / 2;
        float cameraZ = cameraX * cameraY;

        //16x16 Feld - Position muss Coordinate (7.5, 7.5, -28) haben
        //15x15 Feld - Position muss Coordinate (7, 7, -26) haben
        //Problem nur bei Gerade Feldern
        //ungerade genau in Mitte       z achse nicht richtig

        maincamera.transform.position = new Vector3(cameraX,cameraY,-cameraZ);

    }

}
