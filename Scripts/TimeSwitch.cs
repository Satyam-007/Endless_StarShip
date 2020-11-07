using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    public Button onButton;

    public bool pause
    {
        get;
        private set;
    }

    public float sec1;
    public Text Textbox;
    void Start()
    {
        Textbox.text = sec1.ToString();
        Button btn = onButton.GetComponent<Button>();

        btn.onClick.AddListener(paused);
        pause = false;
    }

    void Update()
    {
        if(!pause)
        {
            sec1 += Time.deltaTime;
            int sec = (Mathf.RoundToInt(sec1)) % 60;
            float min = ((int)sec1 / 60);
            float mSecond = Mathf.RoundToInt((sec1 * 10) % 9);
            Textbox.text = min + ":" + sec + ":" + mSecond;
        }
        
    }
    public void paused()
    {
        if (!pause)
        {
            pause = true;
            //Time.timeScale = 0;

        }
        else if (pause)
        {
            pause = false;
            //Time.timeScale = 1;

        }

    }

}