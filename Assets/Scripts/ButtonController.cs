using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField]GameObject[] _manualImgs;
    int i = 0;
    //[SerializeField]GameObject _manualParent;

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < _manualParent.transform.childCount; i++)
        //{
        //    _manualImgs[i] = _manualParent.transform.GetChild(i).GetComponent<GameObject>();
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPage()
    {
        _manualImgs[i].SetActive(false);

        if (i < _manualImgs.Length - 1)
            i++;
        else
            i = 0;

        Debug.Log(i);

        _manualImgs[i].SetActive(true);
       
    }


}
