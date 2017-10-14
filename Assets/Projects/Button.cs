using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("Main");
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("Main");
    }

    public void Dodawanie()
    {
        SceneManager.LoadScene("Dodawanie");
    }

    public void Odejmowanie()
    {
        SceneManager.LoadScene("Odejmowanie");
    }

    public void Mnozenie()
    {
        SceneManager.LoadScene("Mnozenie");
    }

    public void Dzielenie()
    {
        SceneManager.LoadScene("Dzielenie");
    }

    public void Potegowanie()
    {
        SceneManager.LoadScene("Potegowanie");
    }
}
