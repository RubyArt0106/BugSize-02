using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cochi_Follow : MonoBehaviour
{
    public float speed;
    public float rollspeed;
    bool der = true;
    bool dentro;
    bool rolls;

    public Transform disCheck;
    private Transform target;
    private Animator anim;
    /*__________Start___________*/
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }/*__________Start___________*/
    
    /*__________Update___________*/
    void Update()
    {
        
        //Mira al Jugador
        var delta = target.position - transform.position;
        if (delta.x >= 0 && !der)
        {
            transform.localScale = new Vector3(1, 1, 1);
            der = true;
        }
        else if (delta.x < 0 && der)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            der = false;
        }
       
    }/*__________Update___________*/



    private void FixedUpdate()
    {
        
        if (dentro== true && rolls == false)
        {//Camina
            anim.SetBool("isMoving", true);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (anim.GetBool("isRolling"))
        {//Pelotita
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, (speed * rollspeed) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (disCheck == col.gameObject.tag.Equals("Player"))
        {
            dentro = true;
            rolls = false;
            anim.SetBool("isRolling", false);
            anim.SetBool("isMoving", true);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (disCheck == col.gameObject.tag.Equals("Player"))
        {
            if (anim.GetBool("isMoving"))
            {
                rolls = true;
                anim.SetBool("isRolling", true);
            }
            dentro = false;
        }
    }




}
