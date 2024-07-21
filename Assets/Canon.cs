using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject spherePrefab;     // Reference to the sphere prefab
    public Transform firePoint;         // The point from which the sphere will be instantiated
    public GameObject fireEffectPrefab; // Reference to the fire effect prefab
    public float fireForce = 10f;       // The force with which the sphere is fired
    public int maxShots = 5;            // Maximum number of shots the player can fire
    public float destroyDelay = 3f;     // Time after which the sphere will be destroyed

    private int currentShots = 0;       // Current number of shots fired

    void Start()
    {
        // Ensure firePoint is correctly oriented at 60 degrees if it's a child of the cannon
        if (firePoint != null)
        {
            firePoint.localEulerAngles = new Vector3(-53, 0, 0); // Adjust the angle
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentShots < maxShots)
        {
            Fire();
        }
    }

    void Fire()
    {
        if (firePoint == null)
        {
            Debug.LogError("Fire point not assigned.");
            return;
        }

        // Instantiate the sphere at the fire point
        GameObject sphere = Instantiate(spherePrefab, firePoint.position, firePoint.rotation);

        // Apply force to the sphere in the direction of the firePoint's forward vector
        Rigidbody rb = sphere.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * fireForce, ForceMode.Impulse);
        }

        // Instantiate the firing effect
        Instantiate(fireEffectPrefab, firePoint.position, firePoint.rotation);

        // Destroy the sphere after the specified delay
        Destroy(sphere, 2.2f);

        // Increment the shot counter
        currentShots++;
    }
}
