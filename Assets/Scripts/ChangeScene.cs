using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ChangeScene : MonoBehaviour
{
    public Image transitionImage;
    public float transitionSpeed = 2f;
    private bool isFading;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    public void LoadScene(string sceneName)
    {
        if (!isFading)
        {
            StartCoroutine(FadeIn(sceneName));
        }
    }

    IEnumerator FadeIn(string sceneName)
    {
        isFading = true;
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * transitionSpeed;
            transitionImage.color = new Color(0, 0, 0, Mathf.Lerp(0f, 1f, t));
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator FadeOut()
    {
        float tBlack = 1f;

        while (tBlack > 0f)
        {
            tBlack -= Time.deltaTime * transitionSpeed;
            transitionImage.color = new Color(0, 0, 0, 1);
            yield return null;
        }

        float t = 1f;

        while (t > 0f)
        {
            t -= Time.deltaTime * transitionSpeed;
            transitionImage.color = new Color(0, 0, 0, Mathf.Lerp(0f, 1f, t));
            yield return null;
        }

        isFading = false;
    }
}
