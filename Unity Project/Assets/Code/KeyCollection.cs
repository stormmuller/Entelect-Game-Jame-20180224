using UnityEngine;

public class KeyCollection : MonoBehaviour 
{
    public BoolVariable keyCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            keyCollected.Value = true;
            Destroy(gameObject);
        }
    }
}
