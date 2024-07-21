using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    ScoreBoard scoreboard;
    public int Score;
    [SerializeField] float hitpoints = 100f;

    private void Start()
    {
        scoreboard = FindObjectOfType<ScoreBoard>();
    }
    public void TakeDamage(float damage)
    {
        
        hitpoints -= damage;
        if(hitpoints <= 0)
        {
            scoreboard.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
