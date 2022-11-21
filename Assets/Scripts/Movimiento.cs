using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float mainThrust = 10f;
    //[SerializeField] float rotationThrust = 1f;

    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        jump(); 
        movment();
        
    }
        
    void jump(){
        if (Input.GetKey(KeyCode.UpArrow)){
            print("Presionaste arriba");
            //RB.AddRelativeForce(0,1,0);
            RB.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime); 
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            print("Presionaste abajo");
            //RB.AddRelativeForce(0,1,0);
            RB.AddRelativeForce(-Vector3.up * mainThrust * Time.deltaTime); 
        }
        
    }
    
    //(X,Y,Z)
    void movment(){        
        if (Input.GetKey(KeyCode.RightArrow)){
            print("Presionaste derecha");
            RB.AddRelativeForce(1,0,0);
            //transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime); //rota al sentido del reloj
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            print("Presionaste izquierda");
            RB.AddRelativeForce(-1,0,0);
            //transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime); //rota al sentido contrario del reloj
        }
    }

    
}