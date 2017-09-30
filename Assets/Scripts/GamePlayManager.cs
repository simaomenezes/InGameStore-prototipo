using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour {

    private void Start()
    {
        GameObject cannon = Instantiate(GameObject.FindObjectOfType<CannonArray>().cannonPrefabs[GameManager.CANNONINDEXCHECK]);
    }

    public void GotoMainMenu()
    {
        SceneFade.instance.FadeIn("Main Menu");
    }
}
