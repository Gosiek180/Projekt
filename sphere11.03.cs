using UnityEngine;
using System.Collections;

public class sphere : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
        //Pobieramy komponent związany z fizyką kuli
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        //Tworzymy zmienną kierunku, do której przypisujemy wartość zero
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            direction = -Vector3.left;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector3.left;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
        }

        //Do komponentu fizyki dodajemy moment obrotowy zgodny z kierunkiem poruszania się kuli
        rigidbody.AddTorque(direction * 10f);

    }
}
