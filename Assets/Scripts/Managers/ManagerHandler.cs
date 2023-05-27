using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerHandler : MonoBehaviour
{
    public LayerMask GroundLayer;

    private void Awake()
    {
        Manager.GroundLayer = GroundLayer;
        Destroy(gameObject);
    }
}
