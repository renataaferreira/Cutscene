using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jogar()
    {
        // Ajustado para o caminho exato que aparece no seu Build Profile
        SceneManager.LoadScene("Scenes/Cutscene-Motores");
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Jogo fechado");
    }
}
