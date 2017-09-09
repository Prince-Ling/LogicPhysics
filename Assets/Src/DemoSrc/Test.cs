using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public Collider collider1;
    public Collider collider2;

    private VCollisionShape vCollider1;
    private VCollisionShape vCollider2;
    // Use this for initialization
    void Start () {
        vCollider1 = VCollisionShape.createFromCollider(collider1.gameObject);
        vCollider2 = VCollisionShape.createFromCollider(collider2.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        vCollider1.UpdateShape((VInt3)collider1.transform.position, (VInt3)collider1.transform.forward);
        vCollider2.UpdateShape((VInt3)collider2.transform.position, (VInt3)collider2.transform.forward);
        if(vCollider1.Intersects(vCollider2))
        {
            Debug.Log("true");

        }

        if (vCollider1.EdgeIntersects(vCollider2))
        {
            Debug.Log("true22");

        }
    }
}
