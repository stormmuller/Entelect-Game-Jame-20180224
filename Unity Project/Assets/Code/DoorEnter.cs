using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour 
{
    public BoolVariable keyCollected;
    public StringVariable sceneNameVariable;
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && keyCollected)
        {
            keyCollected.Value = false;
            sceneNameVariable.Value = sceneName;
            SceneManager.LoadScene(sceneName);
        }
    }
}
