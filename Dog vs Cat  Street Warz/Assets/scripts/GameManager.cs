using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public GameObject gameOverPanel;

	void Update ()
    {

        if (gameEnded)
            return;

		if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        gameOverPanel.SetActive(true);
        gameEnded = true;
        Debug.Log("GameOver");
    }

    public void restart()
    {
        SceneManager.LoadScene("Defence");
        gameOverPanel.SetActive(false);
    }
}
