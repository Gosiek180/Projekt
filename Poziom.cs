using UnityEngine;
using System.Collections;

public class Poziom : MonoBehaviour 
{
    //stworzenie publicznej zmiennej TextMesh i przypisanie jej komponentu tekstowego
    public TextMesh textMesh;
    //stworzenie publicznej zmiennej tekstowej o nazwie levelName
    public string levelName;

	void Start () 
    {
        //nadanie komponentowi tekstu, tym tekstem jest wartość levelName
        textMesh.text = levelName;
	}

    void OnMouseDown()
    {
        //wczytanie poziomu, którego nazwa znajduje się w zmiennej levelName
        Application.LoadLevel(levelName);
    }
}
