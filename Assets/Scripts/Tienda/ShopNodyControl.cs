using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNodyControl : MonoBehaviour
{

    public MeshFilter playerMesh;
    public CarDB carDB;

    void Start()
    {
        FillShop();
    }

    public void FillShop()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<MeshFilter>().mesh = carDB.carros[i].carMesh;
        }
    }

    public void AssingBody(int id = 0)
    {
        var bodyCar = carDB.carros[id].carMesh;
        playerMesh.mesh = bodyCar;
        transform.GetChild(id).GetChild(0).GetComponent<Rotacion>().carSelected = true;
    }
}
