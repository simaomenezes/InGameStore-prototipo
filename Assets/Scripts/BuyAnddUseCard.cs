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
                ActiveButtonInfo(GameManager.BRONZECANNONCHECK, 1, BRONZE_CANNON);
                break;

            case SILVER_CANNON:
                ActiveButtonInfo(GameManager.SILVERCANNONCHECK, 2, SILVER_CANNON);
                break;

            case ALUMINUN_CANNON:
                ActiveButtonInfo(GameManager.ALUMINUNCANNONCHECK, 3, ALUMINUN_CANNON);
                break;

            case FLAME_CANNON:
                ActiveButtonInfo(GameManager.FLAMECANNONCHECK, 4, FLAME_CANNON);

                break;

            case RAIBOW_CANNON:
                ActiveButtonInfo(GameManager.RAIBOWCANNONCHECK, 5, RAIBOW_CANNON);

                break;

            case CAMOFLAUGE_CANNON:
                ActiveButtonInfo(GameManager.CAMOFLAUGECANNONCHECK, 6, CAMOFLAUGE_CANNON);

                break;

            case CARBONFIBER_CANNON:
                ActiveButtonInfo(GameManager.CARBONFIBERCANNONCHECK, 7, CARBONFIBER_CANNON);

                break;

            case GOLD_CANNON:
                ActiveButtonInfo(GameManager.GOLDCANNONCHECK, 8, GOLD_CANNON);

                break;

            case DIAMOND_CANNON:
                ActiveButtonInfo(GameManager.DIAMONDCANNONCHECK, 9, DIAMOND_CANNON);

                break;
        }
    }

    private void ActiveButtonInfo(int valueCheck, int valueIndex, string cannonName)
    {

        if (valueCheck == 0)
        {
            if (GameManager.CoinCount >= GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].GetComponent<Cannon>().cost)
            {

                StoreManager.instance.justBoughtCannon = true;
                StoreManager.instance.timeBetweenDecrement = StoreManager.instance.decrementTimeConstant / GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[valueIndex].GetComponent<Cannon>().cost;

                valueCheck = 1;
                SetValueCheckPlayerPrefs(cannonName, valueCheck);
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

    // salva nas preferencia de usuario o cannon selecionado | comprado
    private void SetValueCheckPlayerPrefs(string cannonName, int valueCheck)
    {
        switch (cannonName)
        {
            case WOOD_CANNON:
                GameManager.WOODCANNONCHECK = 0;
                StoreManager.instance.EquippedNewCannon(GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[0].gameObject.name, GameManager.instance.GetComponent<CannonArray>().cannonImages[0]);
                break;

            case BRONZE_CANNON:
                GameManager.BRONZECANNONCHECK = valueCheck;
                break;

            case SILVER_CANNON:
                GameManager.SILVERCANNONCHECK = valueCheck;
                break;

            case ALUMINUN_CANNON:
                GameManager.ALUMINUNCANNONCHECK = valueCheck;
                break;

            case FLAME_CANNON:
                GameManager.FLAMECANNONCHECK = valueCheck;
                break;

            case RAIBOW_CANNON:
                GameManager.RAIBOWCANNONCHECK = valueCheck;
                break;

            case CAMOFLAUGE_CANNON:
                GameManager.CAMOFLAUGECANNONCHECK = valueCheck;

                break;

            case CARBONFIBER_CANNON:
                GameManager.CARBONFIBERCANNONCHECK = valueCheck;
                break;

            case GOLD_CANNON:
                GameManager.GOLDCANNONCHECK = valueCheck;
                break;

            case DIAMOND_CANNON:
                GameManager.DIAMONDCANNONCHECK = valueCheck;
                break;
        }
    }
}
