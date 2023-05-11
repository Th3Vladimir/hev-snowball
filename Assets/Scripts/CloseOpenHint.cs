using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CloseOpenHint : MonoBehaviour
{
    public int isActive;
    [SerializeField]
    GameObject panel;

    bool isClosed;
    // Start is called before the first frame update
    void Start()
    {
        //isActive = PlayerPrefs.GetInt("isActive");
        //CloseHint();

        int isHidden = PlayerPrefs.GetInt("hideHintLevel" + SceneManager.GetActiveScene().buildIndex);
        if(isHidden== 0)
        {
            Invoke("OpenHint", 1f);
        }
        else
        {
            CloseHint();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && isClosed) OpenHint();
        else if(Input.GetKeyDown(KeyCode.H) && !isClosed) CloseHint();
    }
    
    public void OpenHint()
    {
        panel.SetActive(true);
        isClosed = false;

        PlayerPrefs.SetInt("hideHintLevel"+SceneManager.GetActiveScene().buildIndex, 0); //open
    }
    public void CloseHint()
    {
        panel.SetActive(false);
        isClosed = true;

        PlayerPrefs.SetInt("hideHintLevel" + SceneManager.GetActiveScene().buildIndex, 1); //closed
    }
}
