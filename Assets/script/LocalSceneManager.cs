using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalSceneManager : MonoBehaviour
{
    
    //메인
    public void OnlcickMain()
    {
        SceneManager.LoadScene("Scenes/Main");
    }
    
    //알선택
    public void OnclickEggSelect()
    {
        SceneManager.LoadScene("Scenes/MonsterSelect");
    }
    
    //탐험
    public void OnlclickAdventure()
    {
        SceneManager.LoadScene("Scenes/Adventure");
    }
    
    //훈련
    public void OnlclickTrainning()
    {
        SceneManager.LoadScene("Scenes/Trainning");
    }
    
    //종료
    public void OnclickQuit()
    {
        Application.Quit();
    }
}
