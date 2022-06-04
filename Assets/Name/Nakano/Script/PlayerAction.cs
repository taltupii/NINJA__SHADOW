using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    #region ïœêîêÈåæ
    public RectTransform target;
    [Space(20)]
    [Header("à⁄ìÆä÷òA")]
    public int moveSpeed = 2;
    public InputAction moveLeft;
    public InputAction moveRight;

    #endregion
    //==========================

    public void Start()
    {
        moveLeft.performed += Moveleft;
        moveRight.performed += MoveRight;

        moveLeft.Enable();
        moveRight.Enable();
    }


    #region à⁄ìÆ
    void move()
    {
        Vector2 tempPostion = target.anchoredPosition;

        if (Keyboard.current.aKey.isPressed)
        {
            tempPostion.x -= moveSpeed;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
            tempPostion.x += moveSpeed;
        }

        target.anchoredPosition = tempPostion;
    }
    #endregion

    void Moveleft(InputAction.CallbackContext callback)
    {
        Vector2 tempPostion = target.anchoredPosition;
        tempPostion.x -= moveSpeed;
        target.anchoredPosition = tempPostion;
    }

    void MoveRight(InputAction.CallbackContext callback)
    {
        Vector2 tempPostion = target.anchoredPosition;
        tempPostion.x += moveSpeed;
        target.anchoredPosition = tempPostion;
    }


    void Update()
    {

    }


}
