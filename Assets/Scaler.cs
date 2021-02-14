using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaler : MonoBehaviour
{
    // WineBottle targets the object itself due to the z plane being on the bottom of the object itself
    public GameObject WineBottle;
    //WineGlass targets the container because it has an adjusted z plane to be on the bottom
    public GameObject WineGlass;
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
        model.transform.localScale += new Vector3(amount, amount, amount);
        PrevValue = value;
    }
}
