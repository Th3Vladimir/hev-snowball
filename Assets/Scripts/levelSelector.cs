using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{
    public int currentLevel;
    public GameObject panelButtons;

    void Start()
    {
        //reset progress
        ///*PlayerPrefs.SetInt("currentLevel", 1);*/
        //--------------------------------------------------------------------
        currentLevel = PlayerPrefs.GetInt("currentLevel");

        if(currentLevel <= 0)
        {
            PlayerPrefs.SetInt("currentLevel", 1);
        }

        foreach (Transform button in panelButtons.transform)
        {

            var buttonText = button.GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>();

            int buttonIndex = int.Parse(buttonText.text.Replace("Level ", "")); //handle this better

            if (buttonIndex < currentLevel)
            {
                button.GetComponent<Button>().interactable = true;
            }

            else if (buttonIndex == currentLevel)
            {
                button.GetComponent<Button>().Select();
            }

            else
            {
                button.GetComponent<Button>().interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerPrefs.SetInt("currentLevel", 1); // resets the progress on "I"
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            for (int i = 1; i <= 5; i++)
            {
                PlayerPrefs.SetInt("hideHintLevel" + i, 0); //open
            }
        }
    }


}
