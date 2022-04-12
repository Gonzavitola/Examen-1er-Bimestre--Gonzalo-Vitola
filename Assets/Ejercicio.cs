using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo y de plateas por separado y luego el total sumado.

public class Ejercicio : MonoBehaviour
{
    public int EntradasCampo;
    public int EntradasPlatea;
    int GananciaPlatea;
    int GananciaCampo;
    int GananciaTotal;
    // Start is called before the first frame update
    void Start()
    {
        GananciaCampo = EntradasCampo * 1200;
        GananciaPlatea = EntradasPlatea * 2000;
        GananciaTotal = GananciaCampo + GananciaPlatea;

        Debug.Log("Lo que se recaudo en campo es:" + GananciaCampo+"pesos. En platea , "+GananciaPlatea+" pesos y en total: "+GananciaTotal+"pesos");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
