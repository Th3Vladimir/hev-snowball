using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CloseOpenHint : MonoBehaviour
{
    public int isActive;
    [SerializeField]
    GameObject panel;

    bool isClosed;
    // Start is called before the first frame update
    void Start()
    {
        isActive = PlayerPrefs.GetInt("isActive");
        CloseHint();
        Invoke("OpenHint", 1f);

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
    }
    public void CloseHint()
    {
        panel.SetActive(false);
        isClosed = true;
    }
}
