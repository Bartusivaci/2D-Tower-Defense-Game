using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    float lives;
    Text livesText;

    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateLivesDisplay();
    }

    private void UpdateLivesDisplay()
    {
        livesText.text = lives.ToString();
    }


    public void LoseLive()
    {
        if (lives > 0)
        {
            lives --;
            UpdateLivesDisplay();
        }
        else
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }


    }

}
