using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider : MonoBehaviour
{
<<<<<<< Updated upstream
    public List<GameObject> points = new List<GameObject>();

    private Vector3 targetPosition = Vector3.zero;
    private int index = 0;

    public float speed = 2f;

    private void Start()
    {
        if (points.Count < 2)
        {
            Debug.Log("Must assign glider 2+ points");
            Destroy(gameObject);
        }

        index = (int)Mathf.Floor(Random.Range(0, points.Count));

        targetPosition = points[index].transform.position;
    }

    private void Update()
    {
        Vector3 diff = targetPosition - transform.position;
        float distance = diff.magnitude;
        diff.Normalize();

        float dotProduct = Vector3.Dot(transform.forward, diff);

        if (dotProduct > 0.9f && distance < speed * Time.deltaTime)
        {
            transform.position = targetPosition;
            int oldIndex = index;
            while (oldIndex == index)
                index = (int)Mathf.Floor(Random.Range(0, points.Count));
            targetPosition = points[index].transform.position;
        }
        else
        {
            transform.position += diff * speed * Time.deltaTime;
            transform.forward = Vector3.Lerp(transform.forward, diff, 0.1f);
        }
    }
}
=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
>>>>>>> Stashed changes
