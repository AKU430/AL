using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LocalUiManager : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Feed;
    
        
    //메뉴 활성화
    public void OnclickMenu()
    {
        Menu.SetActive(!Menu.activeSelf);
    }
    
    //밥
    public void OnclickFeed()
    {
        Feed.SetActive(true);
    }
    
    //밥 취소
    public void OnclickFeedCancel()
    {
        Feed.SetActive(false);  
    }
}
