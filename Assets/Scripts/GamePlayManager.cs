using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour {

    public void GotoMainMenu()
    {
        SceneFade.instance.FadeIn("Main Menu");
    }
}
