using UnityEngine;
using UnityEngine.AI;

public class BasicEnemyScript : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.destination = Target.transform.position;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Player"))
        {
            print("Player Hit");
        }
    }
}
