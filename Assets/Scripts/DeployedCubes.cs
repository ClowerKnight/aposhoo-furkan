using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployedCubes : MonoBehaviour
{
    #region Speed,Force
    public float speed;
    public float force;
    #endregion

    #region Throw
    public virtual void Throw(Vector3 dir)
    {
        speed = 5f;
        force = 9f;
    }
    #endregion


}
