using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAttack : MonoBehaviour
{
    public GameObject Knife;   
    public GameObject obj;
   
    // Start is called before the first frame update
    
    public void ThrowKnife()
    {
        Instantiate(Knife, obj.transform.position, Quaternion.identity);
    }

}
