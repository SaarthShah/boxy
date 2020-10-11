using UnityEngine.SceneManagement;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
