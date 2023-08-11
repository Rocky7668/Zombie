using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level : MonoBehaviour
{

    public Button[] Alllevels;
    public Sprite[] LevelImages;
    public Sprite[] WinImages;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Alllevels.Length; i++)
        {
            Alllevels[i].GetComponent<Image>().sprite = LevelImages[i];
        }
        for (int i = 0; i < 3; i++)
        {
            Alllevels[i].GetComponent<Image>().sprite = WinImages[i];
            Alllevels[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelBtnClick(int n)
    {

    }
}
