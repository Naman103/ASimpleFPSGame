using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager 
{
    private InputAction playerControllerActions;
    private Vector2 movement;

    void OnEnable()
    {
        playerControllerActions.Enable();
    }

    void OnDisable()
    {
        playerControllerActions.Disable();
    }   
}
