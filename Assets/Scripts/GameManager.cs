using System;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Player player;
    private Spawner spawner;
    public TextMeshProUGUI scoreText;
    private int score;
    public GameObject playButton;
    public GameObject gameOver;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
        
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    
    public void Pause()
    {
        Time.timeScale = 0;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
