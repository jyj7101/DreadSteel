using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private PlayerData data;

        private Vector3 moveDirection;


        private void FixedUpdate()
        {
            transform.position += moveDirection * data.playerMoveSpeed;
        }


        public void OnMove(InputAction.CallbackContext context)
        {
            Vector2 input = context.ReadValue<Vector2>();
            if (input != null)
            {
                moveDirection = new Vector3(input.x, 0, 0);
            }
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            // action type == button / 눌려졌는지
            if (context.performed)
            {

            }
        }

    }
}