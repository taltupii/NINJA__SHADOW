using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    #region 変数宣言
    //public RectTransform target;
    //[Space(20)]
    //[Header("移動関連")]
    //public int moveSpeed = 2;

    #region //移動調性
    [Space(20)]
    [Header("速度右")]
    [SerializeField]
    float MoveRight = 0.0f;
    [Space(20)]
    [Header("速度左")]
    [SerializeField]
    float MoveLeft = -0.0f;
    [Space(20)]
    [Header("速度上")]
    [SerializeField]
    float MoveUp = 0.0f;
    [Space(20)]
    [Header("速度下")]
    [SerializeField]
    float MoveDown = 0.0f;
    #endregion
    //public InputAction moveLeft;
    //public InputAction moveRight;

    #endregion
    //==========================

    public void Start()
    {
        //moveLeft.performed += Moveleft;
        //moveRight.performed += MoveRight;

        //moveLeft.Enable();
        //moveRight.Enable();
    }


    //void Moveleft(InputAction.CallbackContext callback)
    //{
    //    Vector2 tempPostion = target.anchoredPosition;
    //    tempPostion.x -= moveSpeed;
    //    target.anchoredPosition = tempPostion;
    //}

    //void MoveRight(InputAction.CallbackContext callback)
    //{
    //    Vector2 tempPostion = target.anchoredPosition;
    //    tempPostion.x += moveSpeed;
    //    target.anchoredPosition = tempPostion;
    //}


    void Update()
    {
        #region//操作取得
        if (Keyboard.current.aKey.isPressed)
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }
        if (Keyboard.current.wKey.isPressed)
        {
            this.transform.Translate(0.0f, 0.1f, 0.0f);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            this.transform.Translate(0.0f, -0.1f, 0.0f);
        }
        #endregion


    }

    //影に入る処理

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("当たった");
        if (other.gameObject.CompareTag("Shadow"))
        {
            this.gameObject.SetActive(false);
        }
    }

}
