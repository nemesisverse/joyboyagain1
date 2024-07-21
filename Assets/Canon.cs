using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject spherePrefab;    // Reference to the sphere prefab
    public Transform firePoint;        // The point from which the sphere will be instantiated
    public GameObject fireEffectPrefab; // Reference to the fire effect prefab
    public float fireForce = 10f;      // The force with which the sphere is fired
    public int maxShots = 5;           // Maximum number of shots the player can fire

    private int currentShots = 3;      // Current number of shots fired

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && currentShots < maxShots)
        {
            Fire();
        }
    }

    void Fire()
    {
        // Instantiate the sphere at the fire point
        GameObject sphere = Instantiate(spherePrefab, firePoint.position, firePoint.rotation);

        // Apply force to the sphere
        Rigidbody rb = sphere.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * fireForce, ForceMode.Impulse);
        }

        // Instantiate the firing effect
        Instantiate(fireEffectPrefab, firePoint.position, firePoint.rotation);

        // Increment the shot counter
        currentShots++;
    }
}
