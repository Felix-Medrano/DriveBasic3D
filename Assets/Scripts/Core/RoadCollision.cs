using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCollision : MonoBehaviour
{

    public Parallax parallax;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            Vector3 pos = this.gameObject.transform.position;
            this.transform.position = new Vector3(pos.x, pos.y, pos.z + 197f);
        }
    }
}
