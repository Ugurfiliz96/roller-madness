using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public int score=0;
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateScoreText();
    }
    void updateScoreText()
    {
        scoreText.text = "Score: "+score.ToString();
    }
}
