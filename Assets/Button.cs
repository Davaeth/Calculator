using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {


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
}
