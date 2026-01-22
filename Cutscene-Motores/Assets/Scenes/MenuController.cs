using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Cutscene-Motores"); // coloque aqui o nome exato da sua cena
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Jogo fechado");
    }
}
