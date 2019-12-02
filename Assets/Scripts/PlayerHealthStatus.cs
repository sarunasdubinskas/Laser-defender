using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthStatus : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerHealthBar;
    [SerializeField] int healthPerBar = 100;
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;

    void Awake()
    {
        SetupSingleton();
    }

    private void SetupSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void SetPlayerHealthStatus(int health)
    {
        string healthText="";
        int countOfHealthBars = health / healthPerBar;
        Debug.Log("countOfHealth: "+countOfHealthBars);
        if (countOfHealthBars >= 0)
        {
            for (int i = 0; i < countOfHealthBars; i++)
            {
                healthText +="^";
            }
            playerHealthBar.text = healthText;
        }
    }

    public void UpdateScoreText(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText(score);
    }

}
