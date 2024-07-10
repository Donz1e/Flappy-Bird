using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.InputSystem.LowLevel;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int recordScore;
    public Text scoreText;
    public Text recordText;
    public GameObject gameOverScreen;
    public BirdScript bird;
    public SoundScript sound;

    private void Start()
    {
        recordScore = PlayerPrefs.GetInt("Record");
        recordText.text = recordScore.ToString();
    }
    void Update()
    {
        if (bird.birdIsAlive == false)
        {
            gameOverScreen.SetActive(true);
        }

        if (playerScore > recordScore)
        {
            breakRecord();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (bird.birdIsAlive)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            sound.playAddScoreSFX();
        }
    }

    public void breakRecord()
    {
        recordScore = playerScore;
        recordText.text = recordScore.ToString();
        PlayerPrefs.SetInt("Record", recordScore);
    }

    public async void restartGame()
    {
        await Task.Delay(273);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        Debug.Log("Quit !");
        Application.Quit();
    }
}