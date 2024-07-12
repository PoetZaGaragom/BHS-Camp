using UnityEngine;

namespace BHS {
    public class ParallaxBehaviour : MonoBehaviour {
        [SerializeField] private Transform _target;
        [SerializeField, Range(0, 1)] private float _horizontMovementMultiplier;
        [SerializeField, Range(0, 1)] private float _verticalMovementMultiplier;

        private Vector3 _targetPosition => _target.position;
        private Vector3 _lastTargetPostition;

        private void Start() {
            _lastTargetPostition = _targetPosition;
        }

        private void Update() {
            Vector3 delta = _targetPosition - _lastTargetPostition;
            delta *= new Vector2(_horizontMovementMultiplier, _verticalMovementMultiplier);
            transform.position += delta;
            _lastTargetPostition = _targetPosition;
        }
    }
}
