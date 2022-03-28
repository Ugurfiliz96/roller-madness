using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour
{
    public bool Finished = false;
    public bool Gameover = false;
    [SerializeField] float levelFinished = 10f;
    [SerializeField] Text Timer;
    [SerializeField] GameObject win, lose;
    [SerializeField] List<GameObject> destoryAfterGame = new List<GameObject>();
    // Start is called before the fi rst frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Gameover==false && Finished==false)
        {
            updateTimer();
        }
        
        if (Time.timeSinceLevelLoad >= levelFinished && Gameover==false && Finished==false)
        {
            print(Time.timeSinceLevelLoad);
            Finished = true;
            print("Next Level");
            win.SetActive(true);
            lose.SetActive(false);
            UpdateOnjects("Objects");
            UpdateOnjects("Enemy");
            foreach (GameObject AllObjects in destoryAfterGame)
            {
                Destroy(AllObjects);
            }
        }
        if (Gameover==true)
        {
            print("Restart");
            win.SetActive(false);
            lose.SetActive(true);
            UpdateOnjects("Objects");
            UpdateOnjects("Enemy");
            foreach (GameObject AllObjects in destoryAfterGame)
            {
                Destroy(AllObjects);
            }
        }
    }
    void UpdateOnjects(string Tag)
    {
        destoryAfterGame.AddRange(GameObject.FindGameObjectsWithTag(Tag));
        
    }
    void updateTimer()
    {
        Timer.text = "Time: " + (int)Time.timeSinceLevelLoad;
    }
}
