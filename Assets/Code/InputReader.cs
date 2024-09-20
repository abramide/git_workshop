using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private Inputs _inputActions;
    
    private Vector2 _movementInput;
    //private bool _shootingInput;

    public Vector2 Movement
    {
        get { return _movementInput;}
    }

    /*public bool Shoot
    {
        get { return _shootingInput;}
    }*/


    // Start is called before the first frame update
    private void Start()
    {

    }

    private void OnEnable()
    {        
        _inputActions = new Inputs();
        _inputActions.PlayerActions.Enable();
        _inputActions.PlayerActions.Move.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        _movementInput = _inputActions.PlayerActions.Move.ReadValue<Vector2>();
        //_shootInput = _inputActions.PlayerActions.Shoot.IsPressed();
    }

    void OnDisable()
    {
        _inputActions.PlayerActions.Disable();
    }
}
