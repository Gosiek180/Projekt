using UnityEngine;
using System.Collections;

public class WyjscieZGry : MonoBehaviour 
{

	void Update () 
    {
        //sprawdzenie czy został naciśnięty klawisz Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //jeśli tak to wychodzimy z gry
            Application.Quit();
        }
	}
}
