using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackHitEvent();
    }


    public void AttackHitEvent()
    {
        if (target == null) return;
        target.takeDamage(damage);
        Debug.Log("bang bang");
    }
}