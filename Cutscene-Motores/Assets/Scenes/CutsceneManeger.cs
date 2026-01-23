using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    public float duracao = 5f;

    void Start()
    {
        Invoke(nameof(CarregarLevel1), duracao);
    }

    public void CarregarLevel1()
    {
        SceneManager.LoadScene(2); // Level1 (pelo seu Build Profiles)
        // ou: SceneManager.LoadScene("Level1");
    }
}
