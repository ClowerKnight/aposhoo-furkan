using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Bomb : Boom
{
    #region Throw,Display
    public override void Throw(Vector3 dir)
    {
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
    public override void Detonate()
    {
        Vector3 expolisonPos = this.transform.position;
        Collider[] colliders = Physics.OverlapSphere(expolisonPos, GetExplosionRange());
        foreach (Collider hit in colliders)
        {
            Rigidbody rigid = hit.GetComponent<Rigidbody>();
            if (rigid != null && !rigid.isKinematic)
            {
                hit.GetComponent<BoxCollider>().isTrigger = true;

                GameManager._Instance.DiscardColoredList(hit.gameObject);
                rigid.AddExplosionForce(force, expolisonPos, GetExplosionRange(), GetUpForce(), ForceMode.Impulse);

            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BrickCube")
        {
            Detonate();

            GameManager._Instance.isThrowing = false;
            
            Destroy(this.gameObject);

        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
    #endregion
}
