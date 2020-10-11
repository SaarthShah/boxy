using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool endgamecount = false;

    public GameObject Gamecompscreen;
    public void LevelWon()
    {
        Gamecompscreen.SetActive(true);
        Debug.Log("Level Complete");
    }
    public void EndGame()
    {
        if (endgamecount == false)
        {
            Debug.Log("GAME OVER");
            endgamecount = true;
            Invoke("Restart",1f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
