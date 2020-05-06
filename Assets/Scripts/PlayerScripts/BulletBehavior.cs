using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

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

        Vector3 target = mouseRay.GetPoint(rayDistance);

        Vector3 fireDirection = target - transform.position;

        transform.forward = fireDirection;

        score = GameObject.Find("Score").GetComponent<ScoreBehavior>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
            return;

        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            return;
        }

        Destroy(collision.gameObject);
        Destroy(gameObject);
        score.score += 5;
    }
}
