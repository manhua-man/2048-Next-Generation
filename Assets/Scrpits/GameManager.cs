/****************************************************
	文件：GameManager.cs
	作者：#CREATEAUTHOR#
	日期：#CREATETIME#
	功能：游戏主控台
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        void MoveUp()
        {

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
    }
}
