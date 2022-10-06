
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private bool _isWorld = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (!_isWorld)
        {
            transform.localRotation = Quaternion.Euler(_rotation);
        }
        else
        {
            transform.rotation = Quaternion.Euler(_rotation);
        }
    }
}
