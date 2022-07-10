using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject image;
    public Health health;
    private void Start()
    {
        image.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (health.currentHealth <= 0)
        {
            image.gameObject.SetActive(true);
        }
        
    }
}
