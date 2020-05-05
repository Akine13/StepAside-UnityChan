using UnityEngine;
using System.Collections;
using UnityEditor;

public class CoinController : MonoBehaviour
{
    private GameObject unitychan;
    private float z;
    // Use this for initialization
    void Start()
    {
        z = this.transform.position.z;
        unitychan = GameObject.FindGameObjectWithTag("unitychanTag");
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (unitychan.transform.position.z >= z + 7)
        {
            Destroy(this.gameObject);
        }
        this.transform.Rotate(0, 3, 0);
    }
}