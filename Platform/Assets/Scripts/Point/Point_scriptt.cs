using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_scriptt : MonoBehaviour
{
    public static int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            score++;
        }
    }


    void Update()
    {
        scoreText.text = score.ToString();
    }
}
