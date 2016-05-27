using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform sphere;
	
	void Update ()
    {
        //Na początku każdej klatki pobieramy komponent fizyki z kuli
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();

        //Obliczamy nową pozycję dla kamery
        Vector3 vector = new Vector3(0, 0.8f, -0.8f);
        //Pobieramy prędkość kuli
        float velocity = rigidbody.velocity.sqrMagnitude;
        //Zmieniamy odległość kamery tak aby zależała od prędkości kuli
        vector = vector * (1f+velocity/4f);

        //Obliczamy nową pozycję kamery
        Vector3 newPosition = sphere.position + vector;

        //Za pomocą transformacji Lerp dostępnej z komponentu Vector3 nadajemy płynne poruszanie kamery
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*2f);
        //Zmuszamy kamerę aby patrzyła dokładnie na środek kuli
        transform.LookAt(sphere);
	}
}
