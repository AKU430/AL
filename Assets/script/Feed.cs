using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Feed : MonoBehaviour
    {
        [SerializeField] private List<FoodInfo> foods;
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI text;
        private int _foodIndex;
        public int Hungerness;
    
        //밥 주기
        public void OnclickFeed(Monster monster)
        {
            if (monster.stat.food == foods[_foodIndex].name)
            {
                monster.stat.hunger += 4;
            }
            else
            {
                monster.stat.hunger += 2;
            }
        }
    
        //다음 음식
        public void OnclickNext()
        {
            _foodIndex++;
            UpdateFood();
        }
    
        //이전 음식
        public void OnclickBefore()
        {
            _foodIndex--;
            UpdateFood();
        }

        public void UpdateFood()
        {
            _foodIndex = Mathf.Clamp(_foodIndex, 0, foods.Count - 1);
            image.sprite = foods[_foodIndex].sprite;
            text.text = foods[_foodIndex].name;
        }
    }

    [Serializable]
    public class FoodInfo
    {
        public string name;
        public Sprite sprite;
    }
}
