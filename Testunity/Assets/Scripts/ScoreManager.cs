using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text countText;
    private int count;

    void Start()
    {
        count = 0;
    }

    public void OnClick()
    {
        StartCoroutine("Count");
    }

    IEnumerator Count()
    {
        while (count < 100.0f)
        {
            yield return new WaitForSeconds(0.05f);
            count++;

            countText.text = count.ToString();

        }
    }
}