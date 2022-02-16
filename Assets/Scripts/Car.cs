using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedIncrement;
    [SerializeField] private float turnSpeed;

    private int steerValue;

    void Update()
    {
        speed += speedIncrement * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

}
