using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulgon_Attack : MonoBehaviour
{
    public float distance;
    bool inside = false;
    public Transform checkInside;
    public GameObject Explosion;
    private Animator anim;

    public AkEvent AtaqueP;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (checkInside == col.gameObject.tag.Equals("Player"))
        {
            Debug.Log(" Inside = " + col.name);
            anim.SetBool("isAtk", true);
            // spawn_Explosion();

            Wwise_AtaqueP();

        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (checkInside == col.gameObject.name.Equals("Player"))
        {
            Debug.Log(" Outside = " + col.name);
            anim.SetBool("isAtk", false);
        }
    }

    void spawn_Explosion()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
    }


    void Wwise_AtaqueP()
    {
        if(AtaqueP != null)
        {
            AtaqueP.HandleEvent(gameObject);
        }
    }

}