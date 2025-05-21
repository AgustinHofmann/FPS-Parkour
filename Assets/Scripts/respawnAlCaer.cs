using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnAlCaer : MonoBehaviour
{

    public float yRespawnValue;

    void Start()
    {
    
        

    }

    
    void Update()
    {

        if (transform.position.y < yRespawnValue)
        {
            //Debug.Log("Me cai");
            SceneManager.LoadScene("FPS Parkour");
        }

    }
}
