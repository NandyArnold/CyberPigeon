
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float score = 0;
    public TextMeshProUGUI scoreText;
    
    [SerializeField]
    private GameObject gameOverScreen;
    
    [SerializeField]
    private GameObject pipeSpawner;

    [SerializeField]
    private GameObject movePipes;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddPoints()
    {
        score = score +1;
        scoreText.text = "Highscore: " + score.ToString();
    } 
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
        

    }
}
