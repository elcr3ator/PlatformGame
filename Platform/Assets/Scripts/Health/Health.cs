using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int damage { get; set; }
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;  
    private bool dead;
    private void Awake()
    {
        currentHealth = startingHealth - damage;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if(currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            damage += 1;
        }

        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<Movement>().enabled = false;
                dead = true;
                
            }
        }

    }
}
