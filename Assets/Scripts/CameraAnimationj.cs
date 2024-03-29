using UnityEngine;

public class CameraAnimationj : MonoBehaviour
{
    [SerializeField] 
    private Animator animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
