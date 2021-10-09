using System.Net;
using UnityEngine;

public class collectible : MonoBehaviour
{
    private Collider colliderObj;
    private void Awake() {
        colliderObj = this.GetComponent<Collider>();
    }
    private void OnCollisionEnter(Collision other)
    {
        //TODO: make it detect collision from player, when collids it increase the required asset value and destroy itself
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
