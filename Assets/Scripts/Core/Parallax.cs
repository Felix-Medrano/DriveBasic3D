using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{

    [Header("Configuracion Parallax")]
    public float parallaxSpeed;

    public GameObject streetA;
    public GameObject streetB;

    [HideInInspector]
    public bool collision;

    private void Update()
    {
        MoveRoad();
    }

    public void MoveRoad()
    {
        Vector3 posActuaA = streetA.transform.position;
        Vector3 posActuaB = streetB.transform.position;
        streetA.transform.position = new Vector3(posActuaA.x, posActuaA.y, posActuaA.z - parallaxSpeed * Time.deltaTime);
        streetB.transform.position = new Vector3(posActuaB.x, posActuaB.y, posActuaB.z - parallaxSpeed * Time.deltaTime);
    }


    public void EfectoParalax(GameObject obj)
    {
        Vector3 pos = obj.transform.position;
        obj.transform.position = new Vector3(pos.x, pos.y, pos.z + 196.45286f);
    }
}
