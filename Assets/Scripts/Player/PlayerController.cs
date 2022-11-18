using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    
    private Vector2 moveInputs;

    private CharacterController controller;
    private Vector3 displacement;
    // Start is called before the first frame update
    void Awake()
    {
        if(controller == null)
            controller = GetComponentInParent<CharacterController>();
        displacement = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       controller.Move(displacement * Time.deltaTime * speed);
    }

    public void setInputMovement(InputAction.CallbackContext ctx)
    {
       moveInputs = ctx.ReadValue<Vector2>();
       displacement.x = moveInputs.x;
       displacement.z = moveInputs.y;
    }
}
