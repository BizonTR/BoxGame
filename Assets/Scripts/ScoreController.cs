using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score;
    public float time;
    void Start()
    {
        time = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player") != null) 
        {
            time -= Time.deltaTime;
        }
        

        if (time < 0)
        {
            score += 1;
            time = 0.01f;
            gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();
        }
    }
}
