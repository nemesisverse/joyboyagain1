using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;

    public void takeDamage(float damage)
    {
        hitpoints -= damage;
        if(hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
  
}
