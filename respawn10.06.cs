using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour 
{
    //tworzenie nowych obiektów
    public GameObject spherePrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;

    public GameObject platformagameover;
    public GameObject nazwapoziomu;

	void Start () 
    {
        //wygenerowanie obiektu i zmienienie mu nazwy
        GameObject sphere = GameObject.Instantiate(spherePrefab);
        sphere.name = "Sphere";
        //nadanie obiektowi odpowiedniego położenia
        sphere.transform.position = transform.position + Vector3.up * 2f;

        //wygenerowanie obiektu
        Camera camera = GameObject.Instantiate(cameraPrefab);
        //poinformowanie obiektu kamery aby patrzyła na kulę
        CameraController cameraController = camera.GetComponent<CameraController>();
        //nakazanie kamerze aby podążała za kulą
        cameraController.sphere = sphere.transform;

        //wydenerowanie obiektu
        Light light = GameObject.Instantiate(lightPrefab);

        //nadanie koloru światłu
        light.color = Color.white;
        //nadanie intensywności światłu
        light.intensity = 0.5f;
        //ustawienie oświetlenia ambientowego
        RenderSettings.ambientLight = Color.white * 0.7f;

        //wygenerowanie obiektów
        GameObject.Instantiate(platformagameover);
        GameObject.Instantiate(nazwapoziomu);
	}
	
	void Update () 
    {
	
	}
}
