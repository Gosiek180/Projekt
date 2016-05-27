using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class krysztal : MonoBehaviour 
{
    public GameObject particles;

    //funkcja informuje o szczegółach kolizji, znajdują się one w obiekcie o nazwie Collider
    void OnTriggerEnter(Collider collision)
    {
        //sprawdzenie jaki obiekt wszedł w interakcję z kryształem, jeśli nie jest to kula, interakcja jest zignorowana
        if(collision.gameObject.name != "Sphere")
        {
            return;
        }

        //jeśli kula dotknęła ostatni kryształ na planszy, zostaje wczytana plansza "win"
        if (leaveCrystals() == 1)
        {
            SceneManager.LoadScene("win");
        }
        //jeśli kula dotknęła jeden z kryształów znajdujących się na planszy, ale nie ostatni, kryształ ten znika
        else
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
        }
    }

    //funkcja zliczająca obecną ilość kryształów na planszy
    int leaveCrystals()
    {
        krysztal[] crystals = Component.FindObjectsOfType<krysztal>();
        return crystals.Length;
    }
}
