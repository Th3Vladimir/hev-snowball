using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[SerializeField] class Finish : MonoBehaviour
{
    [SerializeField] Image transitionImage;
    [SerializeField] float transitionSpeed = 2f;

    [SerializeField] string nextSceneName;
    [SerializeField] GameObject player;
    [SerializeField] GameObject bigBall;
    [SerializeField] GameObject smallBall;
    [SerializeField] TextMeshProUGUI levelNameText;
    [SerializeField] float displayDuration = 1.0f;
    [SerializeField] GameObject loseCanvas;

    public static bool isFading { get; private set; }


    private void Start()
    {
        if (loseCanvas != null)
            loseCanvas.SetActive(false);

        StartCoroutine(FadeOut());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isFading)
        {
            float playerRadius = player.GetComponent<CircleCollider2D>().radius;
            float bigBallRadius = bigBall.GetComponent<CircleCollider2D>().radius;
            float smallBallRadius = smallBall.GetComponent<CircleCollider2D>().radius;
            if (
                playerRadius * player.transform.localScale.x
                    < bigBallRadius * bigBall.transform.localScale.x
                && playerRadius * player.transform.localScale.x
                    > smallBallRadius * smallBall.transform.localScale.x
            )
            {
                PlayerPrefs.SetInt("currentLevel", SceneManager.GetActiveScene().buildIndex + 1);
                PlayerPrefs.Save();

                LoadScene(nextSceneName);
            }
            else
            {
                if (loseCanvas != null)
                    loseCanvas.SetActive(true);
            }
        }
    }

    [SerializeField] void LoadScene(string sceneName)
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

        levelNameText.enabled = true;

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
        levelNameText.enabled = false;
    }
}
