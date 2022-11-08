using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionProgramadorDos : MonoBehaviour
{
    public Transform contenedor;
    // Start is called before the first frame update
    void Start()
    {
        contenedor.localPosition = new Vector2(-(Screen.width + 130), -140);
        contenedor.LeanMoveLocalX(5, 2f).setEaseOutExpo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
