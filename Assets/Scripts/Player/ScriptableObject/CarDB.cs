using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CarDB", menuName = "CarDB", order = 1)]

public class CarDB : ScriptableObject
{
    [System.Serializable]
    public struct carro
    {
        public int id;
        public Mesh carMesh;
        //public Mesh coinMesh;
        public int precio;
        public bool comprado;
        public bool seleccionado;
    }
    public carro[] carros;
}
