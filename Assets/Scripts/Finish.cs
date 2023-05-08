using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//public class Finish : MonoBehaviour
//{
//    [SerializeField] GameObject player;
//    [SerializeField] GameObject bigBall;

//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        Debug.Log("Collided with finish");

//        float playerRadius = player.GetComponent<CircleCollider2D>().radius;
//        float bigBallRadius = bigBall.GetComponent<CircleCollider2D>().radius;
//        if (playerRadius * player.transform.localScale.x < bigBallRadius * bigBall.transform.localScale.x)
//        {
//            // Player has reached the finish, and is small enough to proceed to next level
//            // Add code here to load the next level, or to perform other actions as desired
//            Debug.Log("Next Level");
//        }
//    }
//}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//public class Finish : MonoBehaviour
//{
//    public string nextLevelName;
//    public GameObject player;
//    public GameObject bigBall;
//    public Image fadeOutImage;
//    public TextMeshProUGUI levelNameText;
//    public float fadeOutDuration = 10.0f;
//    public float displayDuration = 1.0f;

//    private bool isTransitioning = false;

//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.gameObject == player && !isTransitioning)
//        {
//            float playerRadius = player.GetComponent<CircleCollider2D>().radius;
//            float bigBallRadius = bigBall.GetComponent<CircleCollider2D>().radius;
//            if (playerRadius * player.transform.localScale.x < bigBallRadius * bigBall.transform.localScale.x)
//            {
//                // Player has reached the finish, and is small enough to proceed to next level
//                StartCoroutine(TransitionToNextLevel());
//            }
//        }
//    }

//    private IEnumerator TransitionToNextLevel()
//    {
//        isTransitioning = true;

//        // Fade out
//        float t = 0.0f;
//        while (t < fadeOutDuration)
//        {
//            float alpha = Mathf.Lerp(0.0f, 1.0f, t / fadeOutDuration);
//            fadeOutImage.color = new Color(0.0f, 0.0f, 0.0f, alpha);
//            t += Time.deltaTime;
//            yield return null;
//        }

//        // Load next level
//        SceneManager.LoadScene(nextLevelName);

//        // Fade in
//        t = 0.0f;
//        while (t < fadeOutDuration)
//        {
//            float alpha = Mathf.Lerp(1.0f, 0.0f, t / fadeOutDuration);
//            fadeOutImage.color = new Color(0.0f, 0.0f, 0.0f, alpha);
//            t += Time.deltaTime;
//            yield return null;
//        }

//        // Display level name
//        levelNameText.enabled = true;
//        yield return new WaitForSeconds(displayDuration);

//        // Hide level name
//        levelNameText.enabled = false;

//        isTransitioning = false;
//    }
//}
public class Finish : MonoBehaviour
{
    public Image transitionImage;
    public float transitionSpeed = 2f;

    public string nextSceneName;
    public GameObject player;
    public GameObject bigBall;
    public TextMeshProUGUI levelNameText;
    public float displayDuration = 1.0f;


    private bool isFading;

    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isFading)
        {
            float playerRadius = player.GetComponent<CircleCollider2D>().radius;
            float bigBallRadius = bigBall.GetComponent<CircleCollider2D>().radius;
            if (playerRadius * player.transform.localScale.x < bigBallRadius * bigBall.transform.localScale.x)
            {
                // Player has reached the finish, and is small enough to proceed to next level
                LoadScene(nextSceneName);
            }
        }
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

        levelNameText.enabled = true;

        while (tBlack> 0f)
        {
            tBlack-= Time.deltaTime * transitionSpeed;
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