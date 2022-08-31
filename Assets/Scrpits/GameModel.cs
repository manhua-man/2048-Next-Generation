/****************************************************
	文件：GameModel.cs
	作者：#CREATEAUTHOR#
	日期：#CREATETIME#
	功能：Nothing
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DYFPS
{

    public class GameModel
    {
        public event Action OnAddScore;
        public int Score
        {
            get; set;
        }

        public int HisScore
        {
            get; set;
        }

        void Save()
        {
            PlayerPrefs.SetInt("历史分数",HisScore);
        }
    }
}
