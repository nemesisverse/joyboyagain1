using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public float duration = 0.2f;  // Duration of the shake effect
    public float magnitude = 0.1f; // Magnitude of the shake effect

    public IEnumerator Shake()
    {
        Vector3 originalPosition = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }
}
