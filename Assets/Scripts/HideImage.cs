using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideImage : MonoBehaviour
{
    [SerializeField] GameObject _obj;

    public void HideImg()
    {
        _obj.SetActive(false);
    }

    public void ShowImg()
    {
        _obj.SetActive(true);
    }

}
