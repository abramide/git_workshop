using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Mover _mover;
    private InputReader _inputs;

    // Start is called before the first frame update
    void Start()
    {
        _mover = GetComponent<Mover>();
        _inputs = GetComponent<InputReader>();
    }

    // Update is called once per frame
    void Update()
    {
        
        _mover.Move(_inputs.Movement);
    }
}
