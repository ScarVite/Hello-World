using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement pm;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            pm.enabled = false;
            pm.rb.linearDamping = 10f;
            FindFirstObjectByType<GameManager>().gameOver();
        }
    }
}
