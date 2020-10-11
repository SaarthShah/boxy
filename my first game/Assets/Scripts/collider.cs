
using UnityEngine;

public class collider : MonoBehaviour
{
    public playermovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.name != "ground")
        {
            GetComponent<playermovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
