using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Chamado quando o botão "Jogar" é clicado
    public void Jogar()
    {
        SceneManager.LoadScene("Game");
        // ou SceneManager.LoadScene(1);
    }

    // Chamado quando o botão "Sair" é clicado
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Jogo fechado");
    }
}
