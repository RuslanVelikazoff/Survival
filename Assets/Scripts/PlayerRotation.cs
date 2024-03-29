using System;
using UnityEngine;

public class PlayerRotation : BaseCharacterRotation
{
    private void FixedUpdate()
    {
        RotateCharacter();
    }
}
