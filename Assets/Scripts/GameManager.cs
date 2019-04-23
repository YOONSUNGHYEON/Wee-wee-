using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Player player;

    public Transform left;
    public Transform center;
    public Transform right;
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }
    public Sprite[] sprites;
    public string spritePath;
    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        Screen.SetResolution(720, Screen.height, true);
        player.transform.position=new Vector3(center.position.x-center.position.x, player.transform.position.y, 0f);

    }


    public Touch leftTouch;
    public Touch rightTouch;
    int touchCount=0;
  

    public void Touch(Touch touch)
    {  
        if (leftTouch == touch)
        {
            if(touchCount != 1)
            {
                player.transform.Translate(left.position.x, left.position.y, 0f);
                touchCount++;
            }
            
        }
        else if (rightTouch == touch)
        {
            if(touchCount != -1)
            {
                player.transform.Translate(right.position.x, right.position.y, 0f);
                touchCount--;
            }
           
        }
    }
}
