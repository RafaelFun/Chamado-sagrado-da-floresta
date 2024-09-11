using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerSprite : MonoBehaviour
{
    public new Transform transform;
    private SpriteRenderer spriteR;
    public Sprite sprCosta;
    public Sprite sprFrente;
    public Sprite sprDireita;
    public Sprite sprEsquerda;
    private CameraController controller;

    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        controller = FindObjectOfType<CameraController>();
    }
    void Update()
    {

        Vector3 direction = base.transform.position - base.transform.position;
        direction.y = 0; 

        

        Quaternion rotation = Quaternion.LookRotation(direction);

        base.transform.rotation = rotation;

        if (controller != null)
        {
            if (controller.cam == 4)
            {
                spriteR.sprite = sprCosta;
            }
            else if (controller.cam == 0)
            {
                spriteR.sprite = sprFrente;
            }
            else if (controller.cam == 2)
            {
                spriteR.sprite = sprDireita;
            }
            else if(controller.cam == 6)
            {
                spriteR.sprite = sprEsquerda;
            }

        }
    }
}
