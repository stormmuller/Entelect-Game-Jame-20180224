using UnityEngine;

public class KeyHover : MonoBehaviour 
{
    const float Frequency = 4f;
    const float YShift = 1.5f;
    const float Stretch = 0.50f;
    const float Squash = 0.4f;

    public float sinMultiplier;

    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        transform.position = originalPosition + new Vector3(0f, (Mathf.Sin(Time.time * Frequency) * Stretch + YShift) * Squash);
    }
}
