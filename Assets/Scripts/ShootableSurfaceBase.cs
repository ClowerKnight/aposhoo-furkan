using System;
using UnityEngine;

public class Sc_ShootableSurface : MonoBehaviour
{
    #region Start
    public int columnCount, rowCount, shootableObjCount;
    public GameObject pre_Brick;
    public virtual void Start()
    {
        BuildWall();
    }
    #endregion

    #region Pos
    public virtual void BuildWall()
    {

    }
    public virtual Vector3 BrickPos(int k, int j)
    {
        throw new NotImplementedException();
    }
    #endregion
}

