using UnityEngine;

public class testCamFollow : MonoBehaviour
{
    private Camera cam;
    private GameObject player;
    private Vector3 offset = new Vector3(0,3,10);
    // Start is called before the first frame update
    void Start()
    {
        cam = FindFirstObjectByType<Camera>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
     cam.transform.position = player.transform.position+offset;   
    }
}
