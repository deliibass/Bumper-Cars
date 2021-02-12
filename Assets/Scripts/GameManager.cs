using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Felt felt;

    public GameObject one, oneCube, two, twoCube, three, threeCube;
    public GameObject firstEnemy, secondEnemy, thirdEnemy;
    public GameObject resultImage;
    public GameObject continueBtn;
    public GameObject buttonPanel;

    private int playerCount = 4;

    public TMP_Text resultText;
    public TMP_Text pCountText;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        StartCoroutine(CountDownRoutine());
    }

    IEnumerator CountDownRoutine()
    {
        three.SetActive(true);
        threeCube.SetActive(true);

        yield return new WaitForSeconds(1);

        three.SetActive(false);
        threeCube.SetActive(false);
        two.SetActive(true);
        twoCube.SetActive(true);

        yield return new WaitForSeconds(1);

        two.SetActive(false);
        twoCube.SetActive(false);
        oneCube.SetActive(true);
        one.SetActive(true);

        yield return new WaitForSeconds(1);
        oneCube.SetActive(false);
        buttonPanel.SetActive(true);
        firstEnemy.SetActive(true);
        secondEnemy.SetActive(true);
        thirdEnemy.SetActive(true);

    }

    private void Update()
    {
        if(felt.enemy1Dead == true && felt.enemy2Dead == true && felt.enemy3Dead == true)
        {
            Time.timeScale = 0f;
            buttonPanel.SetActive(false);
            resultImage.SetActive(true);
            resultText.text = "YOU WON!";
        }
        else if (felt.playerDead == true)
        {
            Time.timeScale = 0f;
            buttonPanel.SetActive(false);
            resultImage.SetActive(true);
            resultText.text = "YOU LOSE!";
        }
    }

    public void CountText(int minus)
    {
        playerCount -= minus;
        pCountText.text = "Player: " + playerCount.ToString();
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgainBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        continueBtn.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        continueBtn.SetActive(false);
    }
}
