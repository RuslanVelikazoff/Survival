using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform transformView;
    
    private void Update()
    {
        transform.position = transformView.position;
        
    }
}