using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int damage = 60;          // Amount of damage dealt to the enemy
    public GameObject hitEffectPrefab;  // Reference to the hit effect prefab

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Instantiate the hit effect at the collision point
        ContactPoint contact = collision.contacts[0];
        GameObject Effect = Instantiate(hitEffectPrefab, contact.point, Quaternion.LookRotation(contact.normal));

        // Deal damage to the enemy if it has an Enemy component
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            Debug.Log("Enemy died.");
            enemy.TakeDamage(damage);
        }
       
        // Destroy the sphere after hitting something
        Destroy(gameObject);
    }
}
