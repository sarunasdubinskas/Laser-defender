using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    PlayerHealthStatus playerHealthStatus;

    void Start()
    {
        playerHealthStatus = FindObjectOfType<PlayerHealthStatus>();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGameOverScene()
    {
        
        Cursor.visible = true;
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }

    public void LoadGameScene()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        playerHealthStatus.ResetScore();
        Cursor.visible = false;
        SceneManager.LoadScene(1);
    }


    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
