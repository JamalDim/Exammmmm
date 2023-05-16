using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode down;
    [SerializeField] private KeyCode up;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    public VectorValue posit;
   

    void Start()
    {
        transform.position = posit.initialValue;
        GetComponent<HP>().damage = 0;
        transform.position = new Vector3(103, -11, 0);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKey(right)&& transform.position.x <= maxX)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(left) && transform.position.x >= minX)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(up) && transform.position.y <= maxY)
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(down) && transform.position.y >= minY)
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
    }

    




}
