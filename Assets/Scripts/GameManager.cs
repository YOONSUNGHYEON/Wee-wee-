using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager GetInstance
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
        sprites = Resources.LoadAll<Sprite>(spritePath);

    }
    public GameObject leftTouch;
    public GameObject rightTouch;
    public GameObject imageObj;
    public Image img;

    void Start()
    {
        ChangeSprite();
    }


    void ChangeSprite()
    {
        imageObj.GetComponent<SpriteRenderer>().sprite = sprites[1];
    }




}
