using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public GameObject setting,home;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("play");
    }

    public void OnSettingClick() 
    {
        home.SetActive(false);
        setting.SetActive(true);
    }
}
