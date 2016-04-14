using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour 
    {

        void OnTriggerEnter(Collider collision)
        {
            // W momencie gdy obiekt o nazwie kula wejdzie w interakcje z kolcami
            if (collision.gameObject.name == "Sphere")
            {
                // Wtedy zostanie pobrana nazwa aktualnego poziomu
                string levelName = SceneManager.GetActiveScene().name;
                //Application.LoadLevel(levelName);
                SceneManager.LoadScene(levelName);
            }
        }

    }
