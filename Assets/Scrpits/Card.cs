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

        
        public Sprite[] CardSprites;//读取图集中所有切片
        private string fileName = "2048";//图集名字
        public int _currentIndex = 0;//当前卡片的显示编号
        private int[] CardScores = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 1024, 2048 };
        private CardModel CardModel;
        private GameModel gameModel;

        private void Awake()
        {
            CardSprites = Resources.LoadAll<Sprite>(fileName);
            CardModel = new CardModel();
            gameModel = new GameModel();
        }

        public void Generate(int index)
        {
            _currentIndex = index;
            CardModel.Score = CardScores[_currentIndex];
            GetComponent<SpriteRenderer>().sprite = CardSprites[_currentIndex];
        }

        public void Merge()
        {
            _currentIndex++;
            //gameModel.OnAddScore += AddScore;
            gameModel.HisScore += CardModel.Score;
            Debug.Log(gameModel.HisScore);
            GetComponent<SpriteRenderer>().sprite = CardSprites[_currentIndex];
        }
        void AddScore()
        {
            Debug.Log(CardModel.Score);
            CardModel.Score = CardScores[_currentIndex];
           
            
        }
    }
}
