using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    GameObject score_object; // Textオブジェクト
    float count;


  
    void Start()
    {
        count = 0;
    }

    public void OnClick()
    {
        count = 0;
        this.score_object = GameObject.Find("Text");

    }

    void Update()
    {
        if (count < 100f)
        {
            count += Time.deltaTime;
            this.score_object.GetComponent<Text>().text = "Score" +
                this.count.ToString("F1");
            
        }

    }

}