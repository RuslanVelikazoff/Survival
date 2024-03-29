using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : BaseCharacterMovement
{
    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rigidbody.MovePosition(transform.position
                                   + movementVector
                                   * runSpeed
                                   * Time.fixedDeltaTime);
        }
        else
        {
            rigidbody.MovePosition(transform.position
                                   + movementVector
                                   * movementSpeed
                                   * Time.fixedDeltaTime);
        }
    }
}
