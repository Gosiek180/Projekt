using UnityEngine;
using System.Collections;

public class Kierunek : MonoBehaviour 
{
    public bool rightDirection = true;

    //funkcja wywołuje się w momencie gdy kula przebywa w interakcji, informuje o szczegółach kolizji
    void OnTriggerStay(Collider collision)
    {
        //pobranie obiektu który wszedł w interakcję
        GameObject thing = collision.gameObject;
        //pobranie komponentu fizyki obiektu
        Rigidbody rigidbody = thing.GetComponent<Rigidbody>();
        //pobranie aktualnej prędkości obiektu
        Vector3 velocity = rigidbody.velocity;

        if (rightDirection)
        {
            //zmienienie prędkości obiektu
            velocity.x = 5f;
        }
        else
        {
            //zmienienie prędkości obiektu
            velocity.x = -5f;
        }

        //aktualizowanie prędkości obiektu
        rigidbody.velocity = velocity;
    }
}
