using UnityEngine;
using UnityEngine.UI;

public class Działanie : MonoBehaviour {

    public InputField input1;
    public InputField input2;

    public Text hasil;

    public void Dodawanie()
    {
        int wynik;

        wynik = int.Parse(input1.text) + int.Parse(input2.text);

        hasil.text = wynik.ToString();
    }

    public void Odejmowanie()
    {
        int wynik;

        wynik = int.Parse(input1.text) - int.Parse(input2.text);

        hasil.text = wynik.ToString();
    }

    public void Mnozenie()
    {
        double wynik;

        wynik = double.Parse(input1.text) * double.Parse(input2.text);

        hasil.text = wynik.ToString();
    }

    public void Dzielenie()
    {
        double wynik;

        wynik = double.Parse(input1.text) / double.Parse(input2.text);

        hasil.text = wynik.ToString();
    }

    public void Potega()
    {
        double wynik;

        wynik = Mathf.Pow(float.Parse(input1.text),float.Parse(input2.text));

        hasil.text = wynik.ToString();
    }
}
