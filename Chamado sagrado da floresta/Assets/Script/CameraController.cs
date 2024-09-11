using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera CameraNorte;
    public Camera CameraSul;
    public Camera CameraLeste;
    public Camera CameraOeste;
    public Camera CameraSuldeste;
    public Camera CameraSuldoeste;
    public Camera CameraNordeste;
    public Camera CameraNoroeste;
    public Player player;
    public PlayerSprite playerSprite;
    private new Transform transform;
    
    public int cam = 0;

    void Start()
    {
        
        UpdateCamera();
        player = FindObjectOfType<Player>();
        transform = GetComponent<Transform>();
        
    }

    void Update()
    {
        
        transform.position = player.transform.position;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            if (cam == 0)
            {
                cam = 7;
            }
            else
            {
                cam--;
            }
            UpdateCamera();  
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            
            if (cam == 7)
            {
                cam = 0;
            }
            else
            {
                cam++;
            }
            UpdateCamera();
        }
    }

    public void ActivateCamera(Camera cameraToActivate)
    {
        
        CameraNorte.gameObject.SetActive(false);
        CameraSul.gameObject.SetActive(false);
        CameraLeste.gameObject.SetActive(false);
        CameraOeste.gameObject.SetActive(false);
        CameraSuldeste.gameObject.SetActive(false);
        CameraSuldoeste.gameObject.SetActive(false);
        CameraNordeste.gameObject.SetActive(false);
        CameraNoroeste.gameObject.SetActive(false);

        // Ativar a câmera desejada
        cameraToActivate.gameObject.SetActive(true);

        playerSprite.transform = cameraToActivate.transform;
    }

    void UpdateCamera()
    {
        switch (cam)
        {
            case 0: ActivateCamera(CameraNorte); break;

            case 1: ActivateCamera(CameraNoroeste); break;

            case 2: ActivateCamera(CameraOeste); break;

            case 3: ActivateCamera(CameraSuldoeste); break;

            case 4: ActivateCamera(CameraSul); break;

            case 5: ActivateCamera(CameraSuldeste); break;

            case 6: ActivateCamera(CameraLeste); break;

            case 7: ActivateCamera(CameraNordeste); break;


        }
    }
    
}
