using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    #region GameObj
    [SerializeField]
    public GameObject pre_Projectile;
    #endregion

    #region Update
    void Update()
    {
        if(GameManager._Instance.isFinish)
        {
            this.GetComponent<UnityEngine.UI.Button>().interactable=false;
        }
    }
    #endregion
}
