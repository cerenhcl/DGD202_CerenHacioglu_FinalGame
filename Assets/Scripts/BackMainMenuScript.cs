using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // MainMenu sahnesine dönme fonksiyonu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
