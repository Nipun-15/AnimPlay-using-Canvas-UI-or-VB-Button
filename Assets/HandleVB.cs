using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HandleVB : MonoBehaviour
{
    // Start is called before the first frame update
    public VirtualButtonBehaviour Punching, Talking;
    public GameObject Nman;
    void Start()
    {
        Punching.RegisterOnButtonPressed(OnPressedPunching);
        Talking.RegisterOnButtonPressed(OnPressedTalking);

    }

    public void OnPressedPunching(VirtualButtonBehaviour Punching)
    {
        Nman.GetComponent<Animator>().Play("Punching");
    }
    public void OnPressedTalking(VirtualButtonBehaviour Talking)
    {
        Nman.GetComponent<Animator>().Play("Talking");
    }

}
