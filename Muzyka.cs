using UnityEngine;
using System.Collections;

public class Muzyka : MonoBehaviour 
{
	void Start () 
	{
		//funkcja informująca środowisko Unity aby nie usuwało aktualnego obiektu (muzyki)
		DontDestroyOnLoad(gameObject);
	}
}
