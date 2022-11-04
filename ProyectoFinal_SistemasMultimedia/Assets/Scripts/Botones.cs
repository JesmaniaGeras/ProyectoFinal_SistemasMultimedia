using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{

    public GameObject panel1, panel2, panel3;

    public void ActivarPanel1()
    {
        panel1.SetActive(true);
    }

    public void ActivarPanel2()
    {
        panel2.SetActive(true);
    }

    public void ActivarPanel3()
    {
        panel3.SetActive(true);
    }

    public void DesactivarPanel1()
    {
        panel1.SetActive(false);
    }

    public void DesactivarPanel2()
    {
        panel2.SetActive(false);
    }

    public void DesactivarPanel3()
    {
        panel3.SetActive(false);
    }
}


