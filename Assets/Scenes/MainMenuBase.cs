using PHUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenuBase : MonoBehaviour
{

    public int ZoomPercent { get; set; } = 100;
    public (int x, int y) Resolution { get; set; } = (1920, 1080);

    [SerializeField]
    Pallet colorPallet;

    GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        canvas = this.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
