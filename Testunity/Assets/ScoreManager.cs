using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text countText;
    private int count;
    private bool flg;

    void Start()
    {
        count = 0;
        flg = true;
    }

    public void OnClick()
    {
        flg = false;
    }

    void Update()
    {
        if (!flg)
        {
            StartCoroutine("Count");
        }
    }

    private IEnumerator Count()
    {
        while(count < 100.0f)
        {
            flg = true;

            yield return new WaitForSeconds(0.05f);
            count++;

            countText.text = count.ToString();

            flg = false;

        }
    }
}