using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class player_Controller : MonoBehaviour
{
    PlayerInput Player_Input;
    InputAction Move_Input, Fire_Input, Exit_Input, Look_Input;
    float Player_Move_Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        Player_Input = new PlayerInput();
    }

    void OnEnable()
    {
        Move_Input = Player_Input.Player.Move;
        Move_Input.Enable();

        Look_Input = Player_Input.Player.Look;
        Look_Input.Enable();

        Fire_Input = Player_Input.Player.Fire;
        Fire_Input.Enable();
        Fire_Input.performed += Fire;

        Exit_Input = Player_Input.Player.Exit;
        Exit_Input.Enable();
        Exit_Input.performed += Exit;
    }

    void OnDisable()
    {
        Move_Input.Disable();
        Fire_Input.Disable();
        Exit_Input.Disable();
    }

    void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fired");
    }

    void Exit(InputAction.CallbackContext context)
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2  Move_Vector2 = Move_Input.ReadValue<Vector2>();
        //Debug.Log(Move_Vector2.x + " " +  Move_Vector2.y);

        transform.Translate(new Vector3 (Move_Vector2.x, 0, Move_Vector2.y) * Time.deltaTime * Player_Move_Speed);
    }   
}
