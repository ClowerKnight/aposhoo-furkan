using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    #region Private,SerializeField
    public bool isShootable;
    [SerializeField]
    private Material[] mat_Bricks;
    [SerializeField]
    private float rigidMass = 0.5f;
    #endregion

    #region Wall,Color
    public void Wall(int a)
    {
        if (a == 1)
        {
            isShootable = true;

            RandomColor();
            Rigidbody rigid = new Rigidbody();
            rigid = this.gameObject.AddComponent<Rigidbody>();
            rigid.mass = rigidMass;
            this.gameObject.layer = 8;
            GameManager._Instance.AddColoredList(this.gameObject);

        }
        else
        {
            isShootable = false;
        }

    }

    public void RandomColor()
    {
        int k = Random.Range(1, mat_Bricks.Length);
        this.GetComponent<Renderer>().material = mat_Bricks[k];
    }
    #endregion

}
