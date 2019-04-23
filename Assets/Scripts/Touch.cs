using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public void Select()
    { //카드가 선택되었다면
        GameManager.Instance.Touch(this);
    }
}
