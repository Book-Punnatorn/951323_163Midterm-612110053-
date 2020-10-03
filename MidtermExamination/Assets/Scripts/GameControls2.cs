using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls2 : MonoBehaviour
{
    public GameObject gameOverText, BackButton, NextButton;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive (false);
        BackButton.SetActive(false);
        NextButton.SetActive(false);
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
            NextButton.SetActive(true);
            
        }
    }
}
