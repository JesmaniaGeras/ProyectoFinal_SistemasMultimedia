using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelProyectoImportante : MonoBehaviour
{
    public Transform box;
    public CanvasGroup[] botones;
    public CanvasGroup botonActivo;


    public void OnEnable()
    {
        botonActivo.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(-277, 0.5f).setEaseOutExpo().delay = 0.1f;

        botones[0].LeanAlpha(0.3f, 0.5f);
        botones[1].LeanAlpha(0.3f, 0.5f);
    }

    public void CloseDialog()
    {
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }
}
