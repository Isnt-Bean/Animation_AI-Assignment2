using System;
using UnityEngine;
using System.Collections;

public class AttackingWithPlayer : MonoBehaviour
{
    public bool Attacking = false;
    public bool Blocking;
    public float Cooldown;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        Block();
    }

    void Attack()
    {
        if (Attacking == false && Blocking == false)
        {
            StartCoroutine(AttackCooldown());
            print("Attacking");
        }
    }

    void Block()
    {
        if (Input.GetKeyDown(KeyCode.F) && Attacking == false)
        {
            Blocking = true;
            print("Blocking");
        }
        else if(Input.GetKeyUp(KeyCode.F))
        {
            Blocking = false;
        }
    }

    IEnumerator AttackCooldown()
    {
        Attacking = true;
        yield return new WaitForSeconds(Cooldown);
        Attacking = false;
        StopCoroutine(AttackCooldown());
    }
    
    
    
    /*
     what I need to create
     
    - animations for enemies and player - after prototype
    
    */
}
