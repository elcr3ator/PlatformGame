using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Heals")
        {
            Destroy(other.gameObject);
          GetComponent<Health>().TakeDamage(-1);
            Health.damage -= 2;
        }
    }

}
