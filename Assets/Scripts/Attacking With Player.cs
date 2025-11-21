using UnityEngine;
using System.Collections;

public class AttackingWithPlayer : MonoBehaviour
{
    public bool Attacking = false;
    public float Cooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void Attack()
    {
        if (Attacking == false)
        {
            StartCoroutine(AttackCooldown());
            print("Attacking");
        }
    }
    IEnumerator AttackCooldown()
    {
        Attacking = true;
        yield return new WaitForSeconds(Cooldown);
        Attacking = false;
        StopCoroutine(AttackCooldown());
    }
}
