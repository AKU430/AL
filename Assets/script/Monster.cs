using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Monster : MonoBehaviour
    {
        public Slider HungerGauge;
        public Slider TiredGauge;
        public Slider WeightGauge;
        
        public MonsterStat stat;

        public TextMeshProUGUI nameText;

        private Image _image;
        [Serializable]
        public class MonsterStat
        {
            public string name;
            public string species;
            public string food;

            public Sprite sprite;
            
            public int atk;
            public int hp;
            public int spd;
        
            public int hunger = 5;
            public int weight = 5;
            public int tired = 5;
        }

        private void Start()
        {
            _image = GetComponent<Image>();
            stat = EggSelectManager.SelectedMonsterStat;
        }

        public void Update()
        {
            _image.sprite = stat.sprite;
            nameText.text = stat.name;
            stat.hunger = (int)Mathf.Clamp(stat.hunger, HungerGauge.minValue, HungerGauge.maxValue);
            HungerGauge.value = stat.hunger;
            stat.tired = (int)Mathf.Clamp(stat.tired, TiredGauge.minValue, TiredGauge.maxValue);
            TiredGauge.value = stat.tired;
            stat.weight = (int)Mathf.Clamp(stat.weight, WeightGauge.minValue, WeightGauge.maxValue);
            WeightGauge.value = stat.weight;
        }
    }
}
