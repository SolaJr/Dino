using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spani : MonoBehaviour {
    public Vector3 center;
    public Vector3 size;
    public GameObject Foodprefab; //before it is made
    //Rotation
    
    // Use this for initialization
    void Start() {
        SpawnFood(); 
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Q))
        { SpawnFood(); }
    }

    public void SpawnFood()
    {
        Vector3 pos = center + new Vector3(Random.Range(20*(-size.x), 20*size.x), Random.Range((-20)*size.y , 20*size.y ));

        Instantiate(Foodprefab, pos, Quaternion.identity);
        transform.Rotate(0, 90, 0);
    }
        

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,.5f);
        Gizmos.DrawCube(center, size);
      }
}
