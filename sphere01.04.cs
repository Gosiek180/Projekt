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

    //Funkcja ta odpowiada za zmianę płaszczyzny poruszania się kuli
    void changeLayer()
    {
        //Po naciśnięciu przycisku "do góry" warstwa zmienia się na dalszą kamerze
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Zmienna isSomething przechowuje informacje czy na drodze kuli znajduje się jakiś obiekt. Ta informacje jest wyciągana z komponentu fizyki. Komponent fizyki pozwala na rzucanie promieni. Promień rozpoczyna się od aktualnej pozycji, następnie wybrany jest jego kierunek i dystans
            bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);

            //Za pomocą konstrukcji if sprawdzane jest czy coś znajduje się na drodze kuli. Jeżeli znajduje się to wtedy w zmiennej !isSomething będzie znajdowała się wartość FALSE (kod wewnątrz instrukcji if nie wykona się), w przeciwnym wypadku TRUE (kod wykona się)
            if(!isSomething)
            {
                //Warstwa znajdująca się dalej kamery
                layer = 1;
            }
        }

        //Po naciśnięciu przycisku "w dół" warstwa zmienia się na bliższą kamerze
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.back, 2f);

            if (!isSomething)
            {
                //Warstwa znajdująca się bliżej kamery
                layer = 0;
            }
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