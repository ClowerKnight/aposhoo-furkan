using UnityEngine;


public class ShootableSurface : Sc_ShootableSurface
{
    #region Surface,Build,Pos
    private int totalBrick;
    public override void Start()
    {

        if ((columnCount * rowCount) <= shootableObjCount)
        {
            shootableObjCount = columnCount * rowCount;
        }
        totalBrick = columnCount * rowCount;

        base.Start();
    }

    public override void BuildWall()
    {

        for (int k = 0; k < rowCount; k++)
        {

            for (int j = 0; j < columnCount; j++)
            {
                GameObject brick = Instantiate(pre_Brick, BrickPos(k, j), Quaternion.identity);
                if (shootableObjCount != 0)
                {
                    if (totalBrick <= shootableObjCount)
                    {
                        brick.GetComponent<Bricks>().Wall(1);
                        shootableObjCount--;
                    }
                    else
                    {
                        int a = Random.Range(0, 5);
                        if (a == 1)
                        {
                            shootableObjCount--;
                            totalBrick--;

                        }
                        else
                        {
                            totalBrick--;
                        }
                        brick.GetComponent<Bricks>().Wall(a);
                    }

                }
                else
                {
                    brick.GetComponent<Bricks>().Wall(0);
                    totalBrick--;
                }



            }
        }
    }
    public override Vector3 BrickPos(int e, int u)
    {
        float x = 0 - ((columnCount / 2f) - (pre_Brick.transform.localScale.x / 2f)) + (u * pre_Brick.transform.localScale.x);
        float y = 0.5f + (e * pre_Brick.transform.localScale.y);
        float z = 4.5f;
        Vector3 brickPos = new Vector3(x, y, z);

        return brickPos;
    }
    #endregion

}
