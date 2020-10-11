using UnityEngine.SceneManagement;
using UnityEngine;

public class gamestart1 : MonoBehaviour
{
    public void butclick()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
