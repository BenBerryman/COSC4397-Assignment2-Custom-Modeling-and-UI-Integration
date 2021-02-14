using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject WineGlass;
    public GameObject WineBottle;
    public Slider RotateSlider;
    public Slider ScaleSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectGlass() {
        WineBottle.SetActive(false);
        WineGlass.SetActive(true);
        RotateSlider.value = 0;
        ScaleSlider.value = 0;
        WineGlass.transform.GetChild(0).transform.localRotation = Quaternion.identity;
        WineGlass.transform.localScale = new Vector3(1, 1, 1);
    }

    public void SelectBottle() {
        WineBottle.SetActive(true);
        WineGlass.SetActive(false);
        RotateSlider.value = 0;
        ScaleSlider.value = 0;
        WineBottle.transform.localRotation = Quaternion.identity;
        WineBottle.transform.GetChild(0).transform.localScale = new Vector3(1, 1, 1);
    }
}
