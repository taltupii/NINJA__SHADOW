using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    #region �ϐ��錾
    //public RectTransform target;
    //[Space(20)]
    //[Header("�ړ��֘A")]
    //public int moveSpeed = 2;

    #region //�ړ�����
    [Space(20)]
    [Header("���x�E")]
    [SerializeField]
    float MoveRight = 0.0f;
    [Space(20)]
    [Header("���x��")]
    [SerializeField]
    float MoveLeft = -0.0f;
    [Space(20)]
    [Header("���x��")]
    [SerializeField]
    float MoveUp = 0.0f;
    [Space(20)]
    [Header("���x��")]
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
        #region//����擾
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

    //�e�ɓ��鏈��

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("��������");
        if (other.gameObject.CompareTag("Shadow"))
        {
            this.gameObject.SetActive(false);
        }
    }

}
