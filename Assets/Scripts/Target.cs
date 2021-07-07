
using UnityEngine;

public class Target : MonoBehaviour
{
    #region SerializeField
    [SerializeField]
      public int target = 10;
    #endregion

    #region Awake

    void Awake()
      {
          QualitySettings.vSyncCount = 0;
          Application.targetFrameRate = target;
      }
    #endregion

    #region Update
    void Update()
      {
          if(Application.targetFrameRate != target)
              Application.targetFrameRate = target;
      }
    #endregion
}
