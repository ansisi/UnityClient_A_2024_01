using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacter : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {

        Move();
    }
    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    public void DestoryCharacter()

    {
        Destroy(gameObject);
    }


}
