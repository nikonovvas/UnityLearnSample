using System.Collections;
using UnityEngine;
[System.Serializable]
public class Del_Transform : MonoBehaviour
{
    [Header("Уничтожение досчерних объектов")]
    [SerializeField]
    [Min(0)]
    private float destroyDelay;

    [SerializeField]
    [Min(0)]
    private int minimalDestroyingObjectsCount;

    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }
    [ContextMenu("Запуск")]
    public void ActivateModule()
    {
        StartCoroutine(DestroyRandomChildObjectCoroutine());
    }

    private IEnumerator DestroyRandomChildObjectCoroutine()
    {
        while (transform.childCount > 0)
        {
            Transform c = transform.GetChild(0);
            Debug.Log(c.name);

            while (c.localScale.x > 0)
            {
                c.localScale -= new Vector3(.1f, .1f, .1f) * Time.deltaTime;
                yield return null;
            }

            Destroy(c.gameObject);
            yield return null;
        }
    }

}

public static class ScaleExtantion
{
    public static bool ValomeLessOrEqual(this Vector3 left, Vector3 right)
    {
        return left.x * left.y * left.z < right.x * right.y * right.z;
    }
}
 
