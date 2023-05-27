using Assets.Scripts.Actor;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum ActorState
{
    Default,
    Stunned,
    Launched
}

[RequireComponent(typeof(Rigidbody))]
public class Actor : MonoBehaviour
{
    private Collider[] hurtbox;

    protected Rigidbody rb;

    [SerializeField] protected ActorStats stats;

    protected ActorState state;
    protected float damage = 0f;
    protected float stunDuration = 0f;
    protected float launchDuration = 0f;
    protected Vector3 launchVelocity;

    public bool grounded => Physics.CheckSphere(transform.position, 0.2f, Manager.GroundLayer);

    public void Hit(HitPackage hit)
    {
        damage += hit.damage;
        launchVelocity = hit.launchAngle;
        stunDuration = hit.stunDuration;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Tick();
    }
    private void FixedUpdate()
    {
        FixedTick();

        switch (state)
        {
            case ActorState.Default: FU_Default(); break;
            case ActorState.Stunned: FU_Stunned(); break;
            case ActorState.Launched: FU_Launched(); break;
        }
    }

    private void FU_Default()
    {

    }
    private void FU_Stunned()
    {
        stunDuration -= Time.fixedDeltaTime;
        if (stunDuration <= 0f)
        {
            state = ActorState.Launched;
            launchDuration = launchVelocity.magnitude * 2f;
        }
    }
    
    private void FU_Launched()
    {
        rb.velocity = launchVelocity;
        launchDuration -= Time.fixedDeltaTime;
        if (launchDuration <= 0f)
        {
            state = ActorState.Default;
        }
    }

    protected virtual void FixedTick() { }
    protected virtual void Tick() { }
}
