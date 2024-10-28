using UnityEngine;
using System.Collections;

public class GameObjectController : MonoBehaviour
{
    private bool isRotating = false;
    private bool isEnlarged = false;

    void Update()
    {
        // Update based on user input or UI button clicks
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating;

        if (isRotating)
        {
            StartCoroutine(RotateObject());
        }
        else
        {
            StopCoroutine(RotateObject());
        }
    }

    public void ToggleEnlargement()
    {
        isEnlarged = !isEnlarged;

        if (isEnlarged)
        {
            EnlargeObject();
        }
        else
        {
            ShrinkObject();
        }
    }

    IEnumerator RotateObject()
    {
        while (isRotating)
        {
            transform.Rotate(Vector3.up, 1.0f);
            yield return null;
        }
    }

    void EnlargeObject()
    {
        transform.localScale *= 2f; // Increase size by 50%
    }

    void ShrinkObject()
    {
        transform.localScale /= 2f; // Decrease size back by 50%
    }
}
