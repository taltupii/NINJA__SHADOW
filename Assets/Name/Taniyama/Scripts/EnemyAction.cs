using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    #region　変数宣言
    [SerializeField, Header("速度")]
    float speed = 1.0f;
    public bool IsSidemove = true;
    [Header("到着地点")]
    public GameObject[] ArrivePos = new GameObject[2];

    Animator Anim;
    Vector3[] tmp_ArrivePos = new Vector3[2];
    Vector3 target_arrivepos;
    bool IsOneSidemove = true;
    #endregion

    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();

        for (int i = 0; i < ArrivePos.Length; ++i)
        {
            tmp_ArrivePos[i] = ArrivePos[i].transform.position;
        }
        isMovedirection();
    }

    private void FixedUpdate()
    {
        // エラー表記
        if (ArrivePos.Length < 2)
        {
            Debug.Log("目的地が正しく設定されていません.\n");
        }

        #region 移動
        float step = speed * Time.fixedDeltaTime;

        if (IsSidemove)
        {
            if(this.transform.position.x == target_arrivepos.x){
                MoveSwitch();
            }
        }else
        {
            if (this.transform.position.y == target_arrivepos.y){
                MoveSwitch();
            }
        }

        Anim.SetBool("Walk", true);
        transform.position = Vector2.MoveTowards(transform.position, target_arrivepos, step);
        #endregion
    }


    /// <summary>
    /// 移動方向を判定する関数
    /// </summary>
    void isMovedirection()
    {
        if (IsSidemove)
        {
            for (int i = 0; i < tmp_ArrivePos.Length; ++i)
            {
                tmp_ArrivePos[i].y = transform.position.y;
            }
        }
        else
        {
            for (int i = 0; i < tmp_ArrivePos.Length; ++i)
            {
                tmp_ArrivePos[i].x = transform.position.x;
            }
        }
        target_arrivepos = tmp_ArrivePos[0];
    }

    /// <summary>
    /// 移動方向の切り替え
    /// </summary>
    void MoveSwitch()
    {
        if (IsOneSidemove)
        {
            transform.localScale = new Vector3(-5.6683f, 4.9237f, 1);
            target_arrivepos = tmp_ArrivePos[1];
            IsOneSidemove = false;
        }
        else
        {
            transform.localScale = new Vector3(5.6683f, 4.9237f, 1);
            target_arrivepos = tmp_ArrivePos[0];
            IsOneSidemove = true;
        }

    }
}
