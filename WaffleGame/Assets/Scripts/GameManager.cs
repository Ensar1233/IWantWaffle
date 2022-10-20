using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Transform plate;
    [SerializeField] private Transform canvas_1;
    public static int moneyScore = 0;
    private void Start()
    {
        Time.timeScale = 0f;
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        canvas_1.gameObject.SetActive(true);
        startButton.gameObject.SetActive(false);

    }
    private void Update()
    {

        FinishGame();
    }
    public void FinishGame()
    {
       if(GameObject.Find("Finish").GetComponent<Finish>().isSpeedUp 
            && GameObject.FindGameObjectsWithTag("Waffle").Length <= 0)
        {

            StartCoroutine("RestartButton");

        }
    }
    IEnumerator RestartButton()
    {
        yield return new WaitForSeconds(2f);
        restartButton.gameObject.SetActive(true);
        Time.timeScale = 0f;
    } 
}
