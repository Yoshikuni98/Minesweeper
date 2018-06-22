using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    [SerializeField]
    private int Zahl = 0;
    public int sizeH = 9;
    public int sizeW = 9;
    public Button Smiley_Normal;
    public Button Smiley_Erstaunt;
    public Button Smiley_Cool;
    public Button Smiley_Traunrig;
    public GameObject BackgroundPlane;

    void Start()
    {
        BackgroundPlane.transform.localScale = new Vector3(sizeW, transform.localScale.y, sizeH+3);

    }

}
