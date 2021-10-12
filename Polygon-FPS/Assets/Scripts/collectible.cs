using UnityEngine;

public class collectible : MonoBehaviour
{
    private Collider colliderObj;
    private string prefabName = "";
    //[SerializeField] Animator animator;
    private void Awake()
    {
        colliderObj = this.GetComponent<Collider>();
    }
    private void Start()
    {
        prefabName = this.tag;
    }
    private void OnCollisionEnter(Collision other)
    {
        //TODO: make it detect collision from player, when collids it preform its task , create the tasks
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Name is " + prefabName);
            Destroy(this.gameObject);
        }
    }
}
