using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    //public Transform checkPos;
    private void OncollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Player") )
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
