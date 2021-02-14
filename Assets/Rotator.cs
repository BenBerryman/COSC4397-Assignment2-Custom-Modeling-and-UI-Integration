using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    //WineGlass targets the object itself because it has a z plane going through the middle of the object
    public GameObject WineGlass;
    //WineBottle targets the container because it has an adjusted z plane to be through the middle of the object
    public GameObject WineBottle;
    public Slider slider;
    private float PrevValue;

    // Start is called before the first frame update
    void Start()
    {
        this.slider.onValueChanged.AddListener(this.SliderChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SliderChange(float value)
    {
        //If WineGlass is currently selected, affect that. Otherwise, affect WineBottle
        GameObject model;
        if (WineGlass.activeInHierarchy)
        {
            model = WineGlass;
        }
        else
        {
            model = WineBottle;
        }
        float amount = value-PrevValue;
        model.transform.Rotate(Vector3.right * amount * 360);
        PrevValue = value;
    }

}
