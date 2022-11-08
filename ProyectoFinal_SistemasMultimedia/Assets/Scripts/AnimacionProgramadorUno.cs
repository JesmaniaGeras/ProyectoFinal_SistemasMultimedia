using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionProgramadorUno : MonoBehaviour
{
    public Transform contenedor;
    // Start is called before the first frame update
    void Start()
    {
        contenedor.localPosition = new Vector2(0, -(Screen.height + 130));
        contenedor.LeanMoveLocalY(-160, 2f).setEaseOutExpo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
