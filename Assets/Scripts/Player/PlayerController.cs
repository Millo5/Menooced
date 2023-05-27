
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : Actor
{

    protected override void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb.AddForce(0, 1f, 0);
            }
        }
    }
    protected override void FixedTick()
    {
    }
}
