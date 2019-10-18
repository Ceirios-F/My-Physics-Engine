using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PhysicsEngineScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 sdfg = new Vector3(5, 15, 3);
        var dsm = Vector3.Scale(new Vector3(), new Vector3(5, 4, 2));

        


        int CurrentShotTypes = 1;

        switch (CurrentShotTypes)
        {
            case 1:
                {
                   
                    Debug.Log("make red power ranger");
                    break;
                }
            case 2:
                {
                    Debug.Log("make blue power ranger");
                    break;
                }
            case 3:
                {
                    Debug.Log("make green power ranger");
                    break;
                }
            case 4:
                {
                    Debug.Log("make green power ranger");
                    break;
                }

            case 5:
                {
                    Debug.Log("make green power ranger");
                    break;
                }

            default:
                break;
        }

    }

    
}

public class AirSpace
{
   
}