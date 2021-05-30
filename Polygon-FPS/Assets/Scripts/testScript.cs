using UnityEngine;

public class testScript : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        for(int i = 0; i < 10;i++)
            for(int j=0;j < 10;j++)
                Instantiate(obj ,new UnityEngine.Vector3(i,0,j) , UnityEngine.Quaternion.identity);
    }
}
