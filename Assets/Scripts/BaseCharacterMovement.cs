using UnityEngine;

public class BaseCharacterMovement : MonoBehaviour
{
    [SerializeField]
    protected float movementSpeed = 6f;

    [SerializeField] 
    protected float runSpeed = 10f;

    protected Vector3 movementVector;
    protected void Update()
    {
        movementVector = transform.right
                         * Input.GetAxis("Horizontal")
                         + Input.GetAxis("Vertical")
                         * transform.forward;
    }
}
