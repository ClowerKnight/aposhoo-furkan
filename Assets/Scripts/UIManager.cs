using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Gameobj,Project,EndGame
    [SerializeField]
   private GameObject pnl_LevelComp;
    void Update()
    {
        if(GameManager._Instance.isFinish)
        {
            StartCoroutine(FinishGame());
        }
    }

    public void GetProjectile(Button btn)
    {
        if (btn is null)
        {
            throw new System.ArgumentNullException(nameof(btn));
        }

        GameManager._Instance.GetProjectile(btn.pre_Projectile);
    }

    private IEnumerator FinishGame()
    {
        yield return new WaitForSeconds(1f);
        pnl_LevelComp.SetActive(true);
        Time.timeScale=0;
    }
    public void Again()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         Time.timeScale=1;
    }

    #endregion
}
