/****************************************************
	文件：GameManager.cs
	作者：#CREATEAUTHOR#
	日期：#CREATETIME#
	功能：游戏主控台
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DYFPS
{

    public class GameManager : MonoBehaviour
    {
        //背景图片
        [SerializeField]
        private GameObject BgSprite;

        private Vector2 BeginPos = new Vector2(-1.5f, 1.5f);//起始点
        private float OffsetY = 1.1f; //xy加个0.1，有个间隙
        private float OffsetX = 1.1f;

        private Vector2 move;
        private PlayerInput player;

        void Start()
        {
           
            CreateBG();
            CreateCard();


        }
        void CreateBG()
        {
            GameObject BG = new GameObject("BG");//创建空游戏对象作为背景预制体//是否在scene视图直接挂载比较好

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Vector2 tmp_NewPos = new Vector2(BeginPos.x + j * OffsetX, BeginPos.y - i * OffsetY);
                    Instantiate(BgSprite, tmp_NewPos, Quaternion.identity, BG.transform);
                }
            }
        }

        void CreateCard()
        {

        }

        void Update()
        {
            if (true)
            {

            }
        }
        void MoveUp(InputAction.CallbackContext callback)
        {
            switch (callback.phase)
            {
                case InputActionPhase.Disabled:
                    break;
                case InputActionPhase.Waiting:
                    break;
                case InputActionPhase.Started:
                    break;
                case InputActionPhase.Performed:
                    Debug.Log("移动中");
                    break;
                case InputActionPhase.Canceled:
                    break;
                default:
                    break;
            }
            move = callback.ReadValue<Vector2>();
        }

        void MoveDown()
        {

        }

        void MoveLeft()
        {

        }

        void MoveRight()
        {

        }

        //private void sur(PlayerInput input)
        //{

        //    for (int i = 0; i < input.currentActionMap.actions.Count; i++)
        //    {
        //        if (input.currentActionMap.actions[i].name == "Fire")
        //        {
        //            input.currentActionMap.actions[i].performed += SwitchRounds_performed;
        //        }
        //    }
        //    // 添加订阅者函数, 当然也可以写成独立的函数
        //    player = GetComponent<PlayerInput>().onActionTriggered +=
        //        callback =>
        //        {
        //            if (callback.action.name == "Move")
        //            {
        //                move = callback.ReadValue<Vector2>();
        //            }
        //        };

        //}
    }
}
