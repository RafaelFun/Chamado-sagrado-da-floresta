using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    public CameraController camctrl;
    public float speed = 5;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        camctrl = FindObjectOfType<CameraController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        

        if (direction.magnitude > 0)
        {

            Quaternion targetRotation = Quaternion.Euler(0, camctrl.transform.rotation.eulerAngles.y, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);


            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
