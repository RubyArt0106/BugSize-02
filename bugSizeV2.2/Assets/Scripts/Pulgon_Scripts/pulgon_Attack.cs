using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulgon_Attack : MonoBehaviour
{
    public float distance;
    public int damageGiven;
    static bool inside = false;
    public GameObject exp_Pos;
    public GameObject Explosion;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        RaycastHit2D disLeft = Physics2D.Raycast(transform.position, Vector2.left, distance);

        if(disLeft.collider != null)
        {
            //Debug.DrawLine(transform.position, disLeft.point, Color.red);
            
            inside = true;
            Debug.Log("Insider "+inside);
            anim.SetBool("isAtk", true);
        }
        else
        {
            inside = false;
            Debug.Log("Out " + inside);
            anim.SetBool("isAtk", false);
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (inside != false)
        {
            if (Explosion == col.gameObject.name.Equals("Player"))
            {
                Debug.Log("player_DAMAGED");
                spawn_Explosion();
                /*
                if (aCheck == col.gameObject.name.Equals("Player"))
                {
                    Debug.Log("player_Attaked");
                    player_Life player = col.GetComponent<player_Life>();
                    if (player != null)
                    {
                        Debug.Log("Attack_true");
                        anim.SetBool("isAttack", true);
                        player.TakeDamage(damageGiven);
                    }
                }**/
            }
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
      /*  if (disCheck == col.gameObject.name.Equals("Player"))
        {
            inside = false;
            Debug.Log("player_OUT"+ inside);
            //anim.SetBool("isAttack", false);
        }*/
    }

    void spawn_Explosion()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
    }

}
