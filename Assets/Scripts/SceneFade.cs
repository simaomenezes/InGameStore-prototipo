using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour {

    public static SceneFade instance;
    public GameObject fadeCanvas;
    public Animator anim;

    private void Awake()
    {
        MakeSingleton();
    }

    private void MakeSingleton()
    {
        if (instance != null) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // gerencia a chamada da animacao para o efeito fade
    private IEnumerator FadeInAnimation(string levelName)
    {
        fadeCanvas.SetActive(true);
        anim.Play("FadeOutAnimation");
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene(levelName);
        anim.Play("FadeInAnimation");
        yield return new WaitForSeconds(1f);
        fadeCanvas.SetActive(false);
    }


    public void FadeIn(string levelName)
    {
        StartCoroutine(FadeInAnimation(levelName));
    }
}
