using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Text scoreText;

    private float scoreCount;

    public float pointsPerSecond;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;
        scoreText.text = " " + Mathf.Round(scoreCount);
    }
}
