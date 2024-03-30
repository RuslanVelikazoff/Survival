using UnityEngine;

public class CameraAnimationj : MonoBehaviour
{
    [SerializeField] 
    private Animator animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)
        || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A)
        || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S)
        || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
