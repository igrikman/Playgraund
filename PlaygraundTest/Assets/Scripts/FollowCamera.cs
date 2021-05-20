using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] private Transform target;
        [SerializeField] private float smoothing = 5f;

        Vector3 offset;

        void Start()
        {
            offset = transform.position - target.position;
        }

        void FixedUpdate()
        {
            if (target != null)
            {
                Vector3 targetCamPos = target.position + offset;
                transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
            }
        }

    }
}
