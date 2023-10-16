using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public float energy = 100;
    public float discharge;

    public GameObject[] segment;
    public Tab_control tablet;
    public Door Door_Ventilation;
    public Door Door_Right_Side;
    public Door Door_Central_Side; 
    public Light Point_Light_Ventilation;
    public Light Point_Light_Coridor;
    public Light Point_Light_Right_Side;

    private void Awake(){
        InvokeRepeating("Discharging", 1f, 1f); 
    }


    private void Update(){
        SetDischarge();
        ViewEnergy();
    }

    private void Discharging(){
        energy-=discharge;
    }

    private void ViewEnergy(){
        if(energy < 75){
            segment[3].SetActive(false);
        }
         if(energy < 50){
            segment[2].SetActive(false);
        }
         if(energy < 25){
            segment[1].SetActive(false);
        }
         if(energy < 0){
            segment[0].SetActive(false);
        }
    }
//розсіхд енергії
    private void SetDischarge(){
        float tableDC;
        float doorsDC;
        float lightDC;
// планшет
        if(tablet.minimap.activeSelf){
            tableDC = 0.3f;
        }else{
            tableDC= 0f;
        }
// зло їбучі двері з мат логікою на перевіс
        if(Door_Central_Side.isOpen == false && Door_Right_Side.isOpen == false && Door_Ventilation.isOpen == false){
            doorsDC = 0.6f;
        }else if(Door_Central_Side.isOpen == true && Door_Right_Side.isOpen == false && Door_Ventilation.isOpen == false){
            doorsDC = 0.4f;
        }else if(Door_Central_Side.isOpen == true && Door_Right_Side.isOpen == true && Door_Ventilation.isOpen == false){
            doorsDC = 0.3f;
        }else if(Door_Central_Side.isOpen == false && Door_Right_Side.isOpen == true && Door_Ventilation.isOpen == true){
            doorsDC = 0.3f;
        }else if(Door_Central_Side.isOpen == true && Door_Right_Side.isOpen == false && Door_Ventilation.isOpen == true){
            doorsDC = 0.3f;
        }else if(Door_Central_Side.isOpen == false && Door_Right_Side.isOpen == true && Door_Ventilation.isOpen == false){
            doorsDC = 0.4f;
        }else if(Door_Central_Side.isOpen == false && Door_Right_Side.isOpen == false && Door_Ventilation.isOpen == true){
            doorsDC = 0.4f;
        }else{
            doorsDC = 0f;
        }

        if(Point_Light_Coridor.doorLight.activeSelf == true || Point_Light_Right_Side.doorLight.activeSelf == true || Point_Light_Ventilation.doorLight.activeSelf == true){
            lightDC = 0.3f;
        }else{
            lightDC = 0f;
        }

        discharge = 0.4f + tableDC +doorsDC + lightDC;
    }
}
