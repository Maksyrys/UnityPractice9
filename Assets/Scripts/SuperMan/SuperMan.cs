using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    public LayerMask goodBoyLayer; 
    public LayerMask badGuyLayer;  
    public float punchForce = 10f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            
            if (CheckLayer(collision.gameObject, goodBoyLayer))
            {
               
                Physics.IgnoreCollision(collision.collider, GetComponent<Collider>(), true);
            }
            else if (CheckLayer(collision.gameObject, badGuyLayer))
            {
               
                Vector3 punchDirection = collision.transform.position - transform.position;
                collision.rigidbody.AddForce(punchDirection.normalized * punchForce, ForceMode.Impulse);
            }
        }
    }

    private bool CheckLayer(GameObject obj, LayerMask layer)
    {
        return layer == (layer | (1 << obj.layer));
    }
}
