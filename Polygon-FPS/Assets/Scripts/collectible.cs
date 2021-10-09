using UnityEngine;

public class collectible : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }
}
