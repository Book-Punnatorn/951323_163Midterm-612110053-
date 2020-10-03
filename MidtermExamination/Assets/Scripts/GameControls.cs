using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
    public GameObject gameOverText, BackButton;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive (false);
        BackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverText.SetActive (true);
            BackButton.SetActive(true);
            
        }
    }
}
