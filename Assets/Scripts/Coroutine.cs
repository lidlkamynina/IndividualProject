using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float scaleChangeInterval = 1.5f;
    public float maxScale = 2f;
    public float minScale = 0.5f;

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
        StartCoroutine(MoveAndScale());
    }

    IEnumerator MoveAndScale()
    {
        while (true)
        {
            MoveSnake();
            yield return new WaitForSeconds(scaleChangeInterval);
            ScaleSnake();
        }
    }

   void MoveSnake()
{
   transform.position += new Vector3(0, 0, 1);
}


    void ScaleSnake()
    {
        float randomScale = Random.Range(minScale, maxScale);
        transform.localScale = initialScale * randomScale;
    }

}

