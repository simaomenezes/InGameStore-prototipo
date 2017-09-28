using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAnddUseCard : MonoBehaviour {

    private Button currentButton;

    private const string WOOD_CANNON = "Wood Cannon";
    private const string BRONZE_CANNON = "Bronze Cannon";
    private const string SILVER_CANNON = "Silver Cannon";
    private const string ALUMINUN_CANNON = "Aluminun Cannon";
    private const string FLAME_CANNON = "Flame Cannon";
    private const string RAIBOW_CANNON = "Raibow Cannon";
    private const string CAMOFLAUGE_CANNON = "Camoflauge Cannon";
    private const string CARBONFIBER_CANNON = "Carbonfiber Cannon";
    private const string GOLD_CANNON = "Gold Cannon";
    private const string DIAMOND_CANNON = "Diamond Cannon";

    private void Awake()
    {
        // pegando o componente do tipo button
        currentButton = GetComponent<Button>();
        //adicionando um metodo para ser escutado pelo evento click do button (dinamico)
        currentButton.onClick.AddListener(() => checkButtonInfo());
    }

    private void checkButtonInfo()
    {
        switch ("" + currentButton.GetComponentInParent<CardPanel>().cannonName.text)
        {
            case WOOD_CANNON:
                GameManager.WOODCANNONCHECK = 0;
                break;

            case BRONZE_CANNON:
                if (GameManager.BRONZECANNONCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[1].GetComponent<Cannon>().cost)
                    {
                        GameManager.BRONZECANNONCHECK = 1;
                        currentButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[1].GetComponent<Cannon>().cost;
                        GameManager.CANNONINDEXCHECK = 1;
                    }
                    else
                    {
                        StoreManager.instance.notEnoughCoinsPanel.gameObject.SetActive(true);
                    }
                } else
                {
                    GameManager.CANNONINDEXCHECK = 1;
                }
                
                break;

            case SILVER_CANNON:
                GameManager.SILVERCANNONCHECK = 0;
                break;

            case ALUMINUN_CANNON:
                GameManager.ALUMINUNCANNONCHECK = 0;
                break;

            case FLAME_CANNON:
                GameManager.FLAMECANNONCHECK = 0;

                break;

            case RAIBOW_CANNON:
                GameManager.RAIBOWCANNONCHECK = 0;

                break;

            case CAMOFLAUGE_CANNON:
                GameManager.CAMOFLAUGECANNONCHECK = 0;

                break;

            case CARBONFIBER_CANNON:
                GameManager.CARBONFIBERCANNONCHECK = 0;

                break;

            case GOLD_CANNON:
                GameManager.GOLDCANNONCHECK = 0;

                break;

            case DIAMOND_CANNON:
                GameManager.DIAMONDCANNONCHECK = 0;
                
                break;
        }
    }
}
