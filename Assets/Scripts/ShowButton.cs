using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    [SerializeField] GameObject _button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide_Button()
    {
        _button.SetActive(false);
    }

    public void Show_Button()
    {
        _button.SetActive(true);
    }

}
