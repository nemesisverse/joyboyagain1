using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    HealthBar healthBar;

    private void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
    }
    public void takeDamage(float damage)
    {
        healthBar.UIDamage(damage);
        hitpoints -= damage;
        if(hitpoints <= 0)
        {
            
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
  
}
