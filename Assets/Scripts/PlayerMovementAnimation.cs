using UnityEngine;

public class PlayerMovementAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
