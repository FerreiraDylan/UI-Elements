using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEffects : MonoBehaviour
{
    [Header("Settings")]
    public float transitionDuration;
    public float uiScale;

    public AnimationCurve animCurve;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonEnter()
    {
    }

    public void ButtonExit()
    {

    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(transitionDuration);
    }
}
