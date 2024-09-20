using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
  public interface IMover
    {
        float Speed { get; }

        void Move(Vector2 direction);
    }

