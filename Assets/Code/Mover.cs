using UnityEngine;

{
    public class Mover : MonoBehaviour
    {
        [field: SerializeField]
        public float Speed
        {
            get;
            private set;
        }

        public void Move(Vector2 direction)
        {
            transform.position += (Vector3)direction * Speed * Time.deltaTime;
        }
    }
}