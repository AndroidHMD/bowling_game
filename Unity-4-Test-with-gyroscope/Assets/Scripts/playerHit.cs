using UnityEngine;
using System.Collections;

public class playerHit : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "projectile")
        {
            Debug.Log("Player was hit!");
            Destroy(col.gameObject);
        }
    }
}
