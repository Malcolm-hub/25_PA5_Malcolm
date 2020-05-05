using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager thismanager;
    public float Score = 0;
    public Text Txt_Score;

    // Start is called before the first frame update
    void Start()
    {
        thismanager = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        Score += 10;
        Txt_Score.text = "Score: " + Score;
        Scene currentscene = SceneManager.GetActiveScene();
        if(Score == 40)
        {
            SceneManager.LoadScene("Level 2");
        }
        if(Score >= 40 && currentscene.name=="Level 2")
        {
            wingame();
        }
    }
    public void wingame()
    {
        SceneManager.LoadScene("WinScene");
    }
}
