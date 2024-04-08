using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RockAbility : Ability
{
    public override void Activate(GameObject parent)
    {
        PlayerController movement = parent.GetComponent<PlayerController>();
        Rigidbody2D rigidbody = parent.GetComponent<Rigidbody2D>();

        rigidbody.velocity = Vector2.zero;
    }
}
