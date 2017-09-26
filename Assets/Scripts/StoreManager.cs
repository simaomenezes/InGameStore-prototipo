using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreManager : MonoBehaviour {

    public GameObject cardPanelPrefab;

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


    public void GotoMainMenu()
    {
        SceneFade.instance.FadeIn("Main Menu");
    }

    private void Awake()
    {
        MakeCardPanel();
    }

    private void MakeCardPanel()
    {
        for (int i = 0; i < GameManager.instance.GetComponent<CannonArray>().cannonPrefabs.Length; i++)
        {
            GameObject card = Instantiate(cardPanelPrefab);

            card.gameObject.name = GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[i].gameObject.name + " Panel";

            card.transform.SetParent(GameObject.Find("Card Holder").transform);

            card.transform.localScale = new Vector3(.85f, .85f, .85f);

            card.GetComponent<CardPanel>().cannonName.text = GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[i].gameObject.name;

            card.GetComponent<CardPanel>().cannonImage.sprite = GameManager.instance.GetComponent<CannonArray>().cannonImages[i];

            card.GetComponent<CardPanel>().cannonImage.SetNativeSize();

            card.GetComponent<CardPanel>().cannonImage.rectTransform.localScale = new Vector3(.4f, .4f, .4f);

            card.GetComponent<CardPanel>().cannonPrice.text = GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[i].GetComponent<Cannon>().cost.ToString();

            switch("" + GameManager.instance.GetComponent<CannonArray>().cannonPrefabs[i].gameObject.name)
            {
                case WOOD_CANNON:
                    card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case BRONZE_CANNON:
                    if (GameManager.BRONZECANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else 
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case SILVER_CANNON:
                    if (GameManager.SILVERCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case ALUMINUN_CANNON:
                    if (GameManager.ALUMINUNCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case FLAME_CANNON:
                    if (GameManager.FLAMECANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case RAIBOW_CANNON:
                    if (GameManager.RAIBOWCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case CAMOFLAUGE_CANNON:
                    if (GameManager.CAMOFLAUGECANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case CARBONFIBER_CANNON:
                    if (GameManager.CARBONFIBERCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case GOLD_CANNON:
                    if (GameManager.GOLDCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;

                case DIAMOND_CANNON:
                    if (GameManager.DIAMONDCANNONCHECK == 0)
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Buy";
                    else
                        card.GetComponent<CardPanel>().buyAndUseButton.GetComponentInChildren<Text>().text = "Use";
                    break;
            }
        }
    }
}
