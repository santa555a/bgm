using UnityEngine;

public class DrawVectorGizmos : MonoBehaviour {
    [SerializeField]
    private Vector3 _startPosition;
    public Vector3 StartPosition {
        get {
            return _startPosition;
        }
        set {
            _startPosition = value;
        }
    }

    [SerializeField]
    private Vector3 _direction;
    public Vector3 Direction
    {
        get
        {
            return _direction;
        }
        set
        {
            _direction = value;
        }
    }

    [SerializeField]
    private float _length = 1.0f;
    public float Length {
        get {
            return _length;
        }
        set {
            _length = value;
        }
    }

    [SerializeField]
    private Color _color = Color.white;
    public Color LineColor {
        set {
            _color = value;
        }
    }

    private float _arrowHeadAngle = 20.0f;
    private float _arrowHeadLength = 0.25f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.DrawLine(_startPosition.position, _endPosition.position, _color);
    }

    private void OnDrawGizmos()
    {
        if (_startPosition != null && _direction != null)
        {
            Vector3 endPosition = (_startPosition) + (_direction.normalized * _length);

            Gizmos.color = _color;
            Gizmos.DrawLine(_startPosition, endPosition);

            Vector3 right = Quaternion.LookRotation(_direction) * Quaternion.Euler(0, 180 + _arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Vector3 left = Quaternion.LookRotation(_direction) * Quaternion.Euler(0, 180 - _arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Gizmos.DrawRay(endPosition, right * _arrowHeadLength);
            Gizmos.DrawRay(endPosition, left * _arrowHeadLength);
        }
    }

}
