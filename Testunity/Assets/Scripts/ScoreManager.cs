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
        flg = false;
    }

    public void OnClick()
    {
        flg = true;
    }

    void Update()
    {
        if (flg)
        {
            if (count < 100)
            {

                count++;

                countText.text = count.ToString();
            }
            else if(count >= 100)
            {
                flg = false;
            }
        }
    }

}

  


        

        
        