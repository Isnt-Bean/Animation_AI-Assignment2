using System;
using UnityEngine;
using System.Collections;

public class AttackingWithPlayer : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Shield;
    
    public Animator animator;
    
    public bool Attacking = false;
    public bool Blocking;
    public float Cooldown;

    void Start()
    {
        Shield.SetActive(false);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        Block();

        if (Attacking)
        {
            Sword.SetActive(true);
            animator.SetBool("Attack", true);
        }
        else
        {
            Sword.SetActive(false);
            animator.SetBool("Attack", false);
        }
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
            Shield.SetActive(true);
            print("Blocking");
        }
        else if(Input.GetKeyUp(KeyCode.F))
        {
            Shield.SetActive(false);
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
