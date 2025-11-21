using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public bool searchForPlayer = false;
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            searchForPlayer = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            searchForPlayer = false;
        }
    }
}