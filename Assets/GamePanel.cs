/****************************************************
	文件：GamePanel.cs
	作者：#CREATEAUTHOR#
	日期：#CREATETIME#
	功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DYFPS
{

    public class GamePanel : MonoBehaviour
    {
        private GameModel gameModel;
        public Text score;

        void Start()
        {
            gameModel = new GameModel();

        }


        void Update()
        {
            score.text = gameModel.HisScore.ToString();
        }
    }
}
