using UnityEngine;
using UnityEngine.AI;

public class BasicEnemyScript : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;

    public DetectPlayer dp;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        //make this activate when in sphere
        if (dp.searchForPlayer)
        {
            agent.destination = Target.transform.position;
        }

    }

}
