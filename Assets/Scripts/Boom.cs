using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : DeployedCubes
{
    #region GetUpForce,SetExplosionRange,Detonate
    private float explosionRange = 5.0f;

    public float GetExplosionRange()
    {
        return explosionRange;
    }

    public void SetExplosionRange(float value)
    {
        explosionRange = value;
    }

    private float upForce;

    public float GetUpForce()
    {
        return upForce;
    }

    public void SetUpForce(float value)
    {
        upForce = value;
    }

    public virtual void Detonate()
    {
       
    }
    #endregion
}
