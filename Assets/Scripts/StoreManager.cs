using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour {

    public void GotoMainMenu()
    {
        SceneFade.instance.FadeIn("Main Menu");
    }

}
