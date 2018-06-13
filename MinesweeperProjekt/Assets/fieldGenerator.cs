using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldGenerator : MonoBehaviour {

    [SerializeField]
    int sizeW = 9;
    [SerializeField]
    int sizeH = 9;
    [SerializeField]
    int bombs = 10;

    public GameObject bomb;
	void Start () {
        //backgroundField.transform.localScale += new Vector3(sizeW, sizeH, 0);
	}
	
	void Update () {
		
	}
}


class sound {

    //public AudioSource soundSource;
    //public List<AudioClip> sfxListe;

                              //Sound     Volume
    //soundSource.PlayOneShot(sfxListe[0], 1f);
}