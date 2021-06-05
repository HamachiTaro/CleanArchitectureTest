using Presenter;
using UnityEngine;

namespace Detail
{
    public class GameView : MonoBehaviour, IGameView
    {
        [SerializeField] private Transform cube;
        
        void Start()
        {
            
        }

        public void ChangePosition(int id, Vector3 position)
        {
            cube.transform.localPosition = position;
        }

        public void ChangeRotation(int id, Vector3 rotation)
        {
            cube.transform.localEulerAngles = rotation;
        }

        public void ChangeScale(int id, Vector3 scale)
        {
            cube.transform.localScale = scale;
        }
    }
}