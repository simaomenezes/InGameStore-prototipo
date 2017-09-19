using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // criamos um atributo do tipo GameManager para ser utilizado como sigleton
    public static GameManager instance;

    private const string CANNON_INDEX = "Cannon Index";

    private const string WOOD_CANNON        = "Wood Cannon";
    private const string BRONZE_CANNON      = "Bronze Cannon";
    private const string SILVER_CANNON      = "Silver Cannon";
    private const string ALUMINUN_CANNON    = "Aluminun Cannon";
    private const string FLAME_CANNON       = "Flame Cannon";
    private const string RAIBOW_CANNON      = "Raibow Cannon";
    private const string CAMOFLAUGE_CANNON  = "Camoflauge Cannon";
    private const string CARBONFIBER_CANNON = "Carbonfiber Cannon";
    private const string GOLD_CANNON        = "Gold Cannon";
    private const string DIAMOND_CANNON     = "Diamond Cannon";



    // Setamos e pegamos na preferencia do usuario o total de moedas
    public static int CoinCount { get { return PlayerPrefs.GetInt("CoinCount"); } set { PlayerPrefs.SetInt("CoinCount", value); } }


    public static int CANNONINDEXCHECK { get { return PlayerPrefs.GetInt(CANNON_INDEX); } set { PlayerPrefs.SetInt(CANNON_INDEX, value); } }

    public static int WOODCANNONCHECK { get { return PlayerPrefs.GetInt(WOOD_CANNON); } set { PlayerPrefs.SetInt(WOOD_CANNON, value); } }

    public static int BRONZECANNONCHECK { get { return PlayerPrefs.GetInt(BRONZE_CANNON); } set { PlayerPrefs.SetInt(BRONZE_CANNON, value); } }

    public static int SILVERCANNONCHECK { get { return PlayerPrefs.GetInt(SILVER_CANNON); } set { PlayerPrefs.SetInt(SILVER_CANNON, value); } }

    public static int ALUMINUNCANNONCHECK { get { return PlayerPrefs.GetInt(ALUMINUN_CANNON); } set { PlayerPrefs.SetInt(ALUMINUN_CANNON, value); } }

    public static int FLAMECANNONCHECK { get { return PlayerPrefs.GetInt(FLAME_CANNON); } set { PlayerPrefs.SetInt(FLAME_CANNON, value); } }

    public static int RAIBOWCANNONCHECK { get { return PlayerPrefs.GetInt(RAIBOW_CANNON); } set { PlayerPrefs.SetInt(RAIBOW_CANNON, value); } }

    public static int CAMOFLAUGECANNONCHECK { get { return PlayerPrefs.GetInt(CAMOFLAUGE_CANNON); } set { PlayerPrefs.SetInt(CAMOFLAUGE_CANNON, value); } }

    public static int CARBONFIBERCANNONCHECK { get { return PlayerPrefs.GetInt(CARBONFIBER_CANNON); } set { PlayerPrefs.SetInt(CARBONFIBER_CANNON, value); } }

    public static int GOLDCANNONCHECK { get { return PlayerPrefs.GetInt(GOLD_CANNON); } set { PlayerPrefs.SetInt(GOLD_CANNON, value); } }

    public static int DIAMONDCANNONCHECK { get { return PlayerPrefs.GetInt(DIAMOND_CANNON); } set { PlayerPrefs.SetInt(DIAMOND_CANNON, value); } }

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


            PlayerPrefs.SetInt(WOOD_CANNON, 1);
            PlayerPrefs.SetInt(BRONZE_CANNON, 0);
            PlayerPrefs.SetInt(SILVER_CANNON, 0);
            PlayerPrefs.SetInt(ALUMINUN_CANNON, 0);
            PlayerPrefs.SetInt(FLAME_CANNON, 0);
            PlayerPrefs.SetInt(RAIBOW_CANNON, 0);
            PlayerPrefs.SetInt(CAMOFLAUGE_CANNON, 0);
            PlayerPrefs.SetInt(CARBONFIBER_CANNON, 0);
            PlayerPrefs.SetInt(GOLD_CANNON, 0);
            PlayerPrefs.SetInt(DIAMOND_CANNON, 0);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
