using System;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public bool searchForPlayer = false;

    private void OnCollisionStay(Collision other)
    {
        if (CompareTag("Player"))
        {
            print("Player is detected");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Exited");
        }
    }
}