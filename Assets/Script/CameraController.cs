using UnityEngine;
using UnityEngine.InputSystem;


public class CameraController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;


    void Start()
    {
        
    }

    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            moveDirection += Vector3.forward;

        if (Keyboard.current.sKey.isPressed)
            moveDirection += Vector3.back;

        if (Keyboard.current.aKey.isPressed)
            moveDirection += Vector3.left;

        if (Keyboard.current.dKey.isPressed)
            moveDirection += Vector3.right;

        transform.position +=
            moveDirection.normalized * moveSpeed * Time.deltaTime;
    }
}
