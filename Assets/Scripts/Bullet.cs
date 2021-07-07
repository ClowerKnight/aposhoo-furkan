using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : DeployedCubes
{
    #region Power
    public override void Throw(Vector3 dir)
   {
        transform.Translate(dir.normalized * speed*Time.deltaTime,Space.World);
        
   }
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("BrickCube"))
        {
        }
        else
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10000f);
            GameManager._Instance.DiscardColoredList(collision.gameObject);
            GameManager._Instance.isThrowing = false;
        }
        Destroy(this.gameObject);

    }
    #endregion

}
