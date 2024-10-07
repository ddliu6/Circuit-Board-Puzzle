using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject[] pics;
    [SerializeField] Text timer;
    public GameObject result;
    public Text resultTime;
    public static GameControl instance;
    public float timeCompleted = 0f;
    bool timerActive = true; //for the pause if needed

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (timerActive)
        {
            string min, sec;
            timeCompleted += Time.deltaTime;
            if (timeCompleted < 60f)
            {
                min = "00";
                sec = Mathf.Floor(timeCompleted).ToString();
                if (sec.Length == 1)
                    sec = "0" + sec;
            }
            else
            {
                min = Mathf.Floor(timeCompleted / 60).ToString();
                sec = Mathf.Floor(timeCompleted % 60).ToString();
                if (min.Length == 1)
                    min = "0" + min;
                if (sec.Length == 1)
                    sec = "0" + sec;
            }
            timer.text = min + ":" + sec;
        }
    }

    private void OnEnable()
    {
        if (instance == null)
            instance = this;
    }

    public bool CheckWin()
    {
        int n = 0;
        while (n < pics.Length)
            if (pics[n++].GetComponent<TouchRotate>().rotation != 0)
                return false;
        //if win
        Time.timeScale = 0;
        if (SceneManager.GetActiveScene().name == "Practice Game")
        {
            result.SetActive(true);
            resultTime.text = timer.text;
        }
        if (SceneManager.GetActiveScene().name == "Formal Game")
        {
            SavedTimer.savedTime = timeCompleted;
            SceneManager.LoadScene("Final Result");
        }
        return true;
    }
}