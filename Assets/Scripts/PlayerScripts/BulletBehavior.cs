using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private Vector3 target;

    public float bulletSpeed = 2;

    public ScoreBehavior score;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        float rayDistance = 0;

        playerPlane.Raycast(mouseRay, out rayDistance);

        target = mouseRay.GetPoint(rayDistance);

        score = GameObject.Find("Score").GetComponent<ScoreBehavior>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = target - transform.position;

        direction.Normalize();
        direction *= bulletSpeed;

        transform.position += direction * Time.deltaTime;
        if(((transform.position.y - target.y >= -1) && (transform.position.y - target.y <= 1)) &&
           ((transform.position.x - target.x >= -1) && (transform.position.x - target.x <= 1)) &&
           ((transform.position.z - target.z >= -1) && (transform.position.z - target.z <= 1)))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        score.score += 5;
    }
}
