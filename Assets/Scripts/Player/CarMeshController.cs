using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMeshController : MonoBehaviour
{
    public int id;
    public CarDB carDB;
    public MeshFilter meshFilter;

    private void OnValidate()
    {
        meshFilter.mesh = carDB.carros[id].carMesh;
    }
}
