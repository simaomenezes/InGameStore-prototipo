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
        currentButton.onClick.AddListener(() => CheckButtonInfo());
    }

    private void CheckButtonInfo()
    {
        Debug.Log(currentButton.GetComponentInParent<CardPanel>().cannonName.text);


        switch (currentButton.GetComponentInParent<CardPanel>().cannonName.text)
        {
            case WOOD_CANNON:
                GameManager.WOODCANNONCHECK = 0;
                StoreManager.instance.EquippedNewCannon(GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[0].gameObject.name,GameManager.instance.GetComponent<CannonArray>().cannonImages[0]);
                break;

            case BRONZE_CANNON:
                ActiveButtonInfo(GameManager.BRONZECANNONCHECK, 1);
                break;

            case SILVER_CANNON:
                ActiveButtonInfo(GameManager.SILVERCANNONCHECK, 2);
                break;

            case ALUMINUN_CANNON:
                ActiveButtonInfo(GameManager.ALUMINUNCANNONCHECK, 3);
                break;

            case FLAME_CANNON:
                ActiveButtonInfo(GameManager.FLAMECANNONCHECK, 4);

                break;

            case RAIBOW_CANNON:
                ActiveButtonInfo(GameManager.RAIBOWCANNONCHECK, 5);

                break;

            case CAMOFLAUGE_CANNON:
                ActiveButtonInfo(GameManager.CAMOFLAUGECANNONCHECK, 6);

                break;

            case CARBONFIBER_CANNON:
                ActiveButtonInfo(GameManager.CARBONFIBERCANNONCHECK, 7);

                break;

            case GOLD_CANNON:
                ActiveButtonInfo(GameManager.GOLDCANNONCHECK, 8);

                break;

            case DIAMOND_CANNON:
                ActiveButtonInfo(GameManager.DIAMONDCANNONCHECK, 9);

                break;
        }
    }

    private void ActiveButtonInfo(int valueCheck, int valueIndex)
    {
        Debug.Log(valueIndex +  "___"  + valueCheck);


        if (valueCheck == 0)
        {
            if (GameManager.CoinCount >= GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].GetComponent<Cannon>().cost)
            {
                valueCheck = 1;
                currentButton.GetComponentInChildren<Text>().text = "Use";
                GameManager.CoinCount -= GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].GetComponent<Cannon>().cost;
                GameManager.CANNONINDEXCHECK = valueIndex;

                StoreManager.instance.EquippedNewCannon(
                    GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].gameObject.name, 
                    GameManager.instance.GetComponent<CannonArray>().cannonImages[valueIndex]
                );
            }
            else
            {
                StoreManager.instance.notEnoughCoinsPanel.gameObject.SetActive(true);
            }
        }
        else
        {
            GameManager.CANNONINDEXCHECK = valueIndex;
            StoreManager.instance.EquippedNewCannon(
                GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].gameObject.name,
                GameManager.instance.GetComponent<CannonArray>().cannonImages[valueIndex]
            );
        }
    }
}
