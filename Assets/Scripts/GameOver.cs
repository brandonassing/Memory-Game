using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    /// <summary>
    /// Controls game over screen
    /// </summary>

    public Text resultGT, scoreGT, timeGT;
    public AudioSource win, lose;

    void Start()
    {
        //Changes text based on game results

        resultGT = GameObject.Find("Result").GetComponent<Text>();
        scoreGT = GameObject.Find("Score").GetComponent<Text>();
        timeGT = GameObject.Find("Time").GetComponent<Text>();

        if (Main.won)
        {
            resultGT.text = "YOU    /    WIN";
            win.Play();
        }
        else
        {
            resultGT.text = "YOU    /   LOSE";
            lose.Play();
        }
        scoreGT.text = "SCORE /  " + Main.finalscore;
        timeGT.text = "TIME   /  " + Main.finalMinutes + ":" + Main.finalSeconds;
    }

}
