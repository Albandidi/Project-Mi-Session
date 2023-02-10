using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Mouv : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.position += new Vector3(inputX, inputY, 0) * Time.deltaTime * 50f;
    }
}
