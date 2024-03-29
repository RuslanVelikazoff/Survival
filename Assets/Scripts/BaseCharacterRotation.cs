using UnityEngine;

public class BaseCharacterRotation : MonoBehaviour
{
    [SerializeField]
    protected float sensivity = 1.5f;
    [SerializeField] 
    protected float smoth = 10f;
    
    protected float yRotation;
    protected float xRotation;
    
    [SerializeField] 
    protected Transform character;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    protected void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * sensivity;
        xRotation -= Input.GetAxis("Mouse Y") * sensivity;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }

    protected void RotateCharacter()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,
            Quaternion.Euler(xRotation,yRotation,0),
            Time.deltaTime * smoth);
        
        character.rotation = Quaternion.Lerp(character.rotation, 
            Quaternion.Euler(0, yRotation,0),
            Time.deltaTime * smoth);
    }
}
