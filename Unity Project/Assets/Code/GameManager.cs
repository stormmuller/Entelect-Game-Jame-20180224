using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    public GameObject character;
    public StringVariable sceneName;
    public BoolVariable keyCollected;

    private CameraFollow cameraFollow;
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    } 

    private void Start()
    {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
        instance = this;
    }

    public void TriggerPlayerDeath()
    {
        keyCollected.Value = false;
        SceneManager.LoadScene(sceneName);
    }
}
