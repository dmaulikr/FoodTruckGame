﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDebuggingConsole : MonoBehaviour {


    public GameObject ShopGO;
    public GameObject WaitingCountInfo;
    public GameObject OrderedCountInfo;

    protected Shop _shop;

    private TextToWorld   _waitingCounterVisualisation;
    private TextToWorld   _orderedCounterVisualisation;


    void Start () {
        _shop = ShopGO.GetComponent<Shop>();

        _waitingCounterVisualisation = WaitingCountInfo.GetComponent<TextToWorld>();
        _orderedCounterVisualisation = OrderedCountInfo.GetComponent<TextToWorld>();
    }//Start
	

	void Update () {
        if (_waitingCounterVisualisation != null)
            _waitingCounterVisualisation.RenderText(_shop.WaitingQ.Count.ToString());
        if (_orderedCounterVisualisation != null)
            _orderedCounterVisualisation.RenderText(_shop.OrderedQ.Count.ToString());
    }//Update

}//class
