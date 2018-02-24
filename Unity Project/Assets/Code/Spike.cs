using UnityEngine;

public class Spike : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            GameManager.Instance.TriggerPlayerDeath();
        }
    }
}
