﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private RaycastHit _hit;
    private LoadLevelInfo _levelInformation;
    [SerializeField] private List<GameObject> nodes;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out _hit, 50))
            {
                if (_hit.transform.GetComponent<LoadLevelInfo>())
                {
                    _levelInformation = _hit.transform.GetComponent<LoadLevelInfo>();
                    SceneManager.LoadScene(_levelInformation.levelNumb);
                }
            }
        }
    }
}
