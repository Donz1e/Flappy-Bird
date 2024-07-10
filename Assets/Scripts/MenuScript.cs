using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Rigidbody2D bird;
    public async void startGame()
    {
        await Task.Delay(273);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public async void quitGame()
    {
        bird.WakeUp();
        await Task.Delay(2500);
        Debug.Log("Quit !");
        Application.Quit();
    }
}
