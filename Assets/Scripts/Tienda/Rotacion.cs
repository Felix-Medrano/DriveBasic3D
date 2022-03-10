using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public Space m_RotateSpace;
    public Vector3 axis;
    public float m_RotateSpeed = 20f;
    [HideInInspector]
    public bool carSelected = false;

    void Update()
    {
        if (carSelected) transform.Rotate(axis * m_RotateSpeed * Time.deltaTime, m_RotateSpace);
    }
}
