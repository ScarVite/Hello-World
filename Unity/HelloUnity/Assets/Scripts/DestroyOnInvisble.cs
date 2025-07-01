using UnityEngine;

public class DestroyOnInvisble : MonoBehaviour
{
    private new GameObject gameObject;

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
