using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour 
{
	IEnumerator Start () 
	{
		//po 5 sekundach od uruchomienia gry przenosi nas z planszy "intro" do planszy "menu"
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("menu");
	}
}
