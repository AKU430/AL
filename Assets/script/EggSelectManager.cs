using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Image = UnityEngine.UI.Image;
using Random = System.Random;


namespace script
{
    public class EggSelectManager : MonoBehaviour
    {
        [SerializeField] private List<Egginfo> eggs;
        [SerializeField] private Image Egg;
        [SerializeField] private List<Monster.MonsterStat> AnotherEgg;
        [SerializeField] private TextMeshProUGUI Species;
        private int _eggIndex;
        public static Monster.MonsterStat SelectedMonsterStat;
        
        //알 선택
        public void OnEggSelect()
        {
            SelectedMonsterStat = AnotherEgg[new Random().Next() % AnotherEgg.Count];
            SceneManager.LoadScene("Main");
        }
    
        //다음 알
        public void OnclickNext()
        {
            _eggIndex++;
            UpdateEgg();
        }
    
        //이전 알
        public void OnclickBefore()
        {
            _eggIndex--;
            UpdateEgg();
        }

        public void UpdateEgg()
        {
            _eggIndex = Mathf.Clamp(_eggIndex, 0, eggs.Count);
            Egg.color = eggs[_eggIndex].color;
            Species.text = eggs[_eggIndex].name;
        }
    }

    [Serializable]
    public class Egginfo
    {
        public string name;
        public Color color;
    }
}