using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rules : MonoBehaviour
{

    private void Update()
    {
        gameObject.transform.Rotate(0f, 0f, 4f * Time.deltaTime * 10f);
    }


}
