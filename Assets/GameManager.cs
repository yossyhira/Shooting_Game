using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text score_text;
    public Text Time_text;

    private int time_count=0;
    private float time=0;
    private float time_reset=1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if(time > time_reset){
            time=0;
            time_count++;
        }

        Time_text.text="Time "+time_count;
        score_text.text="Score: "+score;

    }
}
