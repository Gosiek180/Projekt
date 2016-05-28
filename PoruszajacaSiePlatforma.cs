using UnityEngine;
using System.Collections;

public class PoruszajacaSiePlatforma : MonoBehaviour 
{
	public Vector3 delta;
	//zmienna przechowująca pozycję początkową
	Vector3 startPosition;
	
	void Start () 
	{
		//pobranie pozycji początkowej
		startPosition = transform.position;
	}
	
	void Update () 
	{
		//zmienna przechowująca wartość prędkości platformy
		float velocity = 50f / delta.sqrMagnitude;
		//zmienna przechowująca wartość aktualnej pozycji platformy, która zmienia się od 0 do 1
		float change = (Mathf.Sin(Time.timeSinceLevelLoad*velocity) +1f)/2f;
		
		//skorzystanie z komponentu rigidbody
		Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
		//obliczanie nowej pozycji platformy
		rigidbody.position = Vector3.Lerp(startPosition, startPosition + delta, change);
	}
	
	//funkcja umożliwiająca renderowanie
	void OnDrawGizmos()
	{
		//nadanie koloru
		Gizmos.color = Color.gray;
		
		//zmienienie koloru wyrenderowanego sześcianu aktualnie zaznaczonego elementu
		/*if(Selection.activeTransform == transform)
		{
			Gizmos.color = Color.yellow;
		}*/
		
		//ustawienie pozycji sześcianu
		Vector3 ghostPosition = transform.position + delta;
		//ustawienie wielkości sześcianu
		Vector3 ghostSize = transform.rotation * transform.localScale * 2f;
		
		//narysowanie sześcianu
		Gizmos.DrawWireCube(ghostPosition, ghostSize);
	}
}
