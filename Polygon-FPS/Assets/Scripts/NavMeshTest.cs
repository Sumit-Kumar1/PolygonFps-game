using UnityEngine;
using UnityEngine.AI;
public class NavMeshTest : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
