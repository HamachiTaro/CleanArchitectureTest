using UnityEngine;

namespace Presenter
{
    public interface IGameView
    {
        void ChangePosition(int id, Vector3 position);
        void ChangeRotation(int id, Vector3 rotation);
        void ChangeScale(int id, Vector3 scale);
    }
}