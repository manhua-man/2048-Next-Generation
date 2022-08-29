/****************************************************
	文件：Card.cs
	作者：#CREATEAUTHOR#
	日期：#CREATETIME#
	功能：数字脚本
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DYFPS
{

    public class Card : MonoBehaviour
    {

        [SerializeField]
        public Sprite[] CardSprites;//读取图集中所有切片
        private string fileName = "2048";//图集名字
        public int _currentIndex = 0;//当前卡片的显示编号

        private void Awake()
        {
            CardSprites = Resources.LoadAll<Sprite>(fileName);
        }

        public void Generate(int index)
        {
            _currentIndex = index;
            GetComponent<SpriteRenderer>().sprite = CardSprites[_currentIndex];
        }

        public void Merge()
        {
            _currentIndex++;
            GetComponent<SpriteRenderer>().sprite = CardSprites[_currentIndex];
        }

    }
}
