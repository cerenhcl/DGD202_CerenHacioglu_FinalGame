using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // MainMenu sahnesine d�nme fonksiyonu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
