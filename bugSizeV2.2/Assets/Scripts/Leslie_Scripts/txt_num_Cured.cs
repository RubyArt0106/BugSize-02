using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txt_num_Cured : MonoBehaviour
{
    Text text;
    public static int noCured = 0;
    /*___________Start________*/
    void Start()
    {
        text = GetComponent<Text>();
    }/*___________Start________*/

    /*_______Update___________*/
    void Update()
    {
        if (noCured > 0)
        {
            text.text = "" + noCured;
        }
        else
        {
            text.text = "0";
        }
    }/*_______Update___________*/
}
