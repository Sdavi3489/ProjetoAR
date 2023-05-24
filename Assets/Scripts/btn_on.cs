using UnityEngine;
using Vuforia;

public class btn_on : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
    private GameObject SolarSystem;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("btn_on");
        SolarSystem = GameObject.Find("sistema_solar_3d");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botão on pressionado");
        SolarSystem.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botão off");
        SolarSystem.GetComponent<Animation>().Stop();
    }
}
