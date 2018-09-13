using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Difficulty{
    Beginner,
    Intermediate,
    Profi,
    Custom
}
public class GameController : MonoBehaviour {
    public int sizeH;
    public int sizeW;
    public int bombs;
    public Camera maincamera;
    public GameObject quad;
    float cameraZ;
    [SerializeField]
    Difficulty difficulty;
    DifficultySettings aktDifficulty;
    Dictionary<int, GameObject> quadReference;


    void Start()
    {
        quadReference = new Dictionary<int, GameObject>();
        DifficultySettings beginner = new DifficultySettings(9, 9, 10, 4f, 4f);
        DifficultySettings intermediate = new DifficultySettings(16, 16, 40, 7.5f, 7.5f);
        DifficultySettings profi = new DifficultySettings(30, 16, 99, 0, 0);
        DifficultySettings custom = new DifficultySettings(sizeW, sizeH, bombs, 0, 0);
        switch (difficulty)
        {
            case Difficulty.Beginner:
                GridGen(beginner);
                aktDifficulty = beginner;
                break;
            case Difficulty.Intermediate:
                GridGen(intermediate);
                aktDifficulty = intermediate;
                break;
            case Difficulty.Profi:
                GridGen(profi);
                aktDifficulty = profi;
                break;
            case Difficulty.Custom:
                GridGen(custom);
                aktDifficulty = custom;
                break;
            default:
                GridGen(beginner);
                aktDifficulty = beginner;
                break;
        }
        MineLogic(aktDifficulty);
    }
    
    void GridGen(DifficultySettings ds)
    {
        int counter = 0;
        for (int y = 0; y < ds.GetCol(); y++)
        {
            for (int x = 0; x < ds.GetRows(); x++)
            {
                //float f = Mathf.PerlinNoise();
                GameObject quads = Instantiate(quad);
                quadReference.Add(counter, quads);
                quads.transform.position += new Vector3(x, y, 0);
                quads.transform.SetParent(transform);
                counter++;
            }
        }
        print("Quads: " + counter);

        float maintrans = maincamera.transform.position.z;

        maincamera.transform.position = new Vector3(ds.GetCamX(), ds.GetCamY(), maintrans);

    }

    void MineLogic(DifficultySettings d)
    {
        List<int> numbers;
        for (int i = 0; i < d.GetMineCount(); i++)
        {
            
        }
    }

    void Reset()
    {

    }

    

}