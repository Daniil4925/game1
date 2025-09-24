using UnityEngine;
using UnityEngine.Rendering;

public abstract class bot : MonoBehaviour
{
    [SerializeField] protected int speed; 
    [SerializeField] protected Transform[] path;
    private int index;
    protected virtual void move()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, path[index].position, step);
        if (Vector3.Distance(transform.position, path[index].position) < 0.01f)
        {
            if (index + 1 < path.Length)
            {
                index = index + 1;
            }
        }
    }
   void Update()
    {
        move();
    }
    

    
   
}
