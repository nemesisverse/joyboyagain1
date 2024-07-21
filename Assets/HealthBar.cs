using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthbar;

    public float healthamount = 100f;

    private void Update()
    {
        
    }

    public void UIDamage(float damage)
    {
        healthamount -= damage;
        healthbar.fillAmount = healthamount/100f;
    }
}
