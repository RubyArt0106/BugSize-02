using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txt_kill_Mun : MonoBehaviour
{
    Text text;
    public static int noMunicion = 40;
    /*___________Start________*/
    void Start()
    {
        text = GetComponent<Text>();
    }/*___________Start________*/

    /*_______Update___________*/
    void Update()
    {
        if(noMunicion > 0)
        {
            text.text = "" + noMunicion;
        }
        else
        {
            text.text = "0";
        }
    }/*_______Update___________*/
}
