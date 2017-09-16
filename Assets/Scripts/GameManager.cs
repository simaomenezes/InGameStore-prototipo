using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // criamos um atributo do tipo GameManager para ser utilizado como sigleton
    public static GameManager instance;

    // Setamos e pegamos na preferencia do usuario o total de moedas
    public static int CoinCount { get { return PlayerPrefs.GetInt("CoinCount"); } set { PlayerPrefs.SetInt("CoinCount", value); } }

    private void Awake()
    {
        MakeSingleton();
    }

    private void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {

        if (!PlayerPrefs.HasKey("HASPLAYDGAMEBEFORE"))
        {
            PlayerPrefs.SetInt("HASPLAYDGAMEBEFORE", 0);

            PlayerPrefs.SetInt("CoinCount", 0);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
