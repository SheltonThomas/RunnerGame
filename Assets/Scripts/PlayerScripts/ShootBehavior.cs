using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        float rayDistance = 0;

        playerPlane.Raycast(mouseRay, out rayDistance);

        Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

        Vector3 fireDirection = targetPoint - transform.position;

        transform.forward = fireDirection;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
