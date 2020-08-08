using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemLoad : MonoBehaviour
{
    GameObject controller;
    public string nameAsset, nameBundle;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        gameObject.GetComponent<Button>().onClick.AddListener(() => { controller.GetComponent<LoadAsset>().LoadLocal(nameAsset, nameBundle); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
