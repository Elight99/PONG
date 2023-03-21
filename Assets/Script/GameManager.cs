using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreL.text = PlayerScoreR.ToString();
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            Debug.Log("player 1 Win ");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("player 2 Win ");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
    }
    public void Score(string wallID)
    {
        if(wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 10;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }
}
