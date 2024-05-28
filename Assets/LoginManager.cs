using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Cuando el usuario presione el botón Aceptar:
//se debe escribir un mensaje en la consola
//Si el texto de inputPassword coincide con la contraseña predeteminada escribir "Access granted"
//Sino escribir "Access denied"


public class LoginManager : MonoBehaviour
{
    public string Contraseña;
    public InputField Ingresar_Contraseña;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IngresoContraseña()
    {
    if (Ingresar_Contraseña.text == Contraseña)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
