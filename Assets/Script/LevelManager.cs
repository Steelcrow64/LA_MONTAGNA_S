using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Restart()
    {
        //1- Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //2- Rest the player's position
        //Save the player's initial position when game starts
        //When respawning simply repositin the player to that init position 
    }
}
