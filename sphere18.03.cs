using UnityEngine;
using System.Collections;

public class sphere : MonoBehaviour
{
    //Warstwa, w której aktualnie znajduje się kula przechowywana jest w zmiennej całkowitej layer
    int layer = 0;

    //Zmienna fizyczna kuli rigidbody została przeniesiona bezpośrednio do klasy i jest ona widoczna w każdej z funkcji
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    //Wszystkie linijki z funkcji Update zostały przeniesione do dwóch nowych funkcji, które wykonywane są w każdej klatce
    void Update()
    {
        changeLayer();
        changePosition();
    }

    //Funkcja ta otrzymała gotowe już instrukcje warunkowe odpowiadające za przechwytywanie naciśnięć klawiszy góra, dół
    void changeLayer()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Warstwa znajdująca się dalej kamery
            layer = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Warstwa znajdująca się bliżej kamery
            layer = 0;
        }

        //Różnica między idealną pozycją kuli, a aktualną
        float delta = (layer * 2f - 2f) - rigidbody.position.z;

        //Pobieranie aktualnej prędkości
        Vector3 velocity = rigidbody.velocity;
        //Zmienienie prędkości
        velocity.z = delta * 3f;
        //Przypisanie wektora prędkości obiektowi fizycznemu
        rigidbody.velocity = velocity;
    }

    //Funkcja ta nie uległa większej zmianie
    void changePosition()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
        }

        rigidbody.AddTorque(direction * 25f);
    }
}