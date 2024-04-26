using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera360 : MonoBehaviour
{
    Gyroscope m_Gyro;
    // Start is called before the first frame update
    void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        //Output the rotation rate, attitude and the enabled state of the gyroscope as a Label
        GUI.Label(new Rect(500, 300, 200, 40), "Gyro rotation rate " + m_Gyro.rotationRate);
        GUI.Label(new Rect(500, 350, 200, 40), "Gyro attitude" + m_Gyro.attitude);
        GUI.Label(new Rect(500, 400, 200, 40), "Gyro enabled : " + m_Gyro.enabled);
    }
}
