using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nazwapoziomu : MonoBehaviour 
{
    // Komponent wyświetlający tekst
    public TextMesh textMesh;
    
    void Start () 
    {
        // Na początku planszy ładowana jest nazwa poziomu
        string levelName = SceneManager.GetActiveScene().name;
        // Nazwa ta zostaje przypisana do tekstu wyświetlanego przez komponent textMesh
        textMesh.text = levelName;
	}
}
