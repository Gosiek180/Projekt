using UnityEngine;
using System.Collections;

public class PowrotDoMenu : MonoBehaviour 
{
	void Update () 
    {
        //sprawdzenie czy został naciśnięty klawisz Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //jeśli tak to zostanie wczytana plansza "menu"
            Application.LoadLevel("menu");
        }
	}
}
