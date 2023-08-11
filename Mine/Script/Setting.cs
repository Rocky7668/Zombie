using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics.Contracts;

public class Setting : MonoBehaviour
{
    public Sprite On, Off;
    public Button sound, music;
    internal int Sound, Music;
    public GameObject setting1,home,gameoverpanel;
    // Start is called before the first frame update
    void Start()
    {
        Sound = PlayerPrefs.GetInt("sound");
        Music = PlayerPrefs.GetInt("music");


        Debug.Log(Sound + Music);
    }

    // Update is called once per frame
    void Update()
    {
        if (Sound == 1) sound.GetComponent<Image>().sprite = On;
        else sound.GetComponent<Image>().sprite = Off;

        if (Music == 1) music.GetComponent<Image>().sprite = On;
        else music.GetComponent<Image>().sprite = Off;

    }

    public void onclicksound()
    {
        if (sound.GetComponent<Image>().sprite == On)
        {
            sound.GetComponent<Image>().sprite = Off;
            Sound = 0;
            PlayerPrefs.SetInt("sound", Sound);
        }
        else
        {
            sound.GetComponent<Image>().sprite = On;
            Sound = 1;
            PlayerPrefs.SetInt("sound", Sound);
        }
        Debug.Log("s" + Sound);
    }
    public void onclickmusic()
    {

        if (music.GetComponent<Image>().sprite == On)
        {
            music.GetComponent<Image>().sprite = Off;

        }
        else
        {
            music.GetComponent<Image>().sprite = On;

        }
        if (music.GetComponent<Image>().sprite == On) Music = 1;
        else Music = 0;
        PlayerPrefs.SetInt("music", Music);

        Debug.Log("m" + Music);

    }
    public void exit()
    {
        setting1.SetActive(false);
        //home.SetActive(true);
        SceneManager.LoadScene("Home");
    }

    public void OnHomeClick()
    {
        gameoverpanel.SetActive(false);
        SceneManager.LoadScene("Home");
    }

   public void OnRetryClick()
    {
        SceneManager.LoadScene("play");
    }

}
