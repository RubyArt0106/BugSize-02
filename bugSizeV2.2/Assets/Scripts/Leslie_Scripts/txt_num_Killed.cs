using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txt_num_Killed : MonoBehaviour
{
    Text text;
    public static int noKilled = 0;
    /*___________Start________*/
    void Start()
    {
        text = GetComponent<Text>();
    }/*___________Start________*/

    /*_______Update___________*/
    void Update()
    {
        if (noKilled > 0)
        {
            text.text = "" + noKilled;
        }
        else
        {
            text.text = "0";
        }
    }/*_______Update___________*/
}
