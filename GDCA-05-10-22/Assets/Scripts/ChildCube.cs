using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class ChildCube : MonoBehaviour
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
            
            gameObject.transform.localRotation = Quaternion.Euler(_rotation); // transform child ve parentleri icinde tutar
            gameObject.transform.GetChild(0); // only work with transform
        }
        else
        {
            transform.rotation = Quaternion.Euler(_rotation);
        }
    }
}
