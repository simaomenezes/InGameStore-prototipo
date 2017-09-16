using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

    public Text currentCoinText;

    private void Update()
    {
        currentCoinText.text = GameManager.CoinCount.ToString();
    }


    //Adiciona Moedas
    public void IncrementCoint()
    {
        GameManager.CoinCount++;
    }

    public void GotoGame()
    {
        SceneFade.instance.FadeIn("Game");
    }

    public void GotoStore()
    {
        SceneFade.instance.FadeIn("Store");
    }
}
