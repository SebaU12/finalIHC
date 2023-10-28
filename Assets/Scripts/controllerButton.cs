using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelConfirmacion;
    public CubeButton cube1;
    void Start()
    {
        Debug.Log("Inicia?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OptionSelectedTrue()
    {
        // Cambia el material del cubo al hacer clic.
        Debug.Log("Opción elegida");
        cube1.resetMaterial(); 
        panelConfirmacion.SetActive(false);
    }
    public void OptionSelectedFalse()
    {
        // Cambia el material del cubo al hacer clic.
        Debug.Log("Opción elegida");
        cube1.resetMaterial(); 
        panelConfirmacion.SetActive(false);
    }
}
