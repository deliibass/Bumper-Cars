using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject soundOn, soundOff;
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsBtn()
    {
        soundOn.SetActive(true);
        soundOff.SetActive(true);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
