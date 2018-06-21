using UnityEngine;
[RequireComponent(typeof(Light))]
public class LightBall : Stuff {
    [SerializeField]
    private GameObject Door;
    [SerializeField]
    private float Rmax;
    [SerializeField]
    private float Rmin;
    [SerializeField]
    private float Hmax;
    [SerializeField]
    private float Hmin;
    [SerializeField]
    private float ClearTime;
    [SerializeField]
    private GameObject SpotParticle;
    [SerializeField]
    private GameObject AreaParticles;

    private Light _thisLight { get; set; }
    private float _time { get; set; }
    private bool _isClear { get; set; }
    private bool _onClick { get; set; }
    private float _scaleMax;
    private void Awake()
    {
        _thisLight = GetComponent<Light>();
        _time = 0;
        _onClick = false;
        _isClear = false;
        _scaleMax = transform.lossyScale.x;
    }

    public override void OnClickDown()
    {
        base.OnClickDown();
        _onClick = true;
    }

    private void FixedUpdate()
    {
        if (_isClear) return;
        if (_onClick) {
            _time += Time.deltaTime;
            _thisLight.intensity = 2 * (ClearTime - _time) / ClearTime;
            transform.localScale = new Vector3(1,1,1) * _scaleMax * (ClearTime - _time) / ClearTime;
            if (ClearTime <= _time) {
                Clear();
                _time = 0;
            }
        }
    }
    public override void OnClickUp()
    {
        base.OnClickUp();
        _onClick = false;
        if (_isClear) return;
        RandomWarp();
        transform.localScale = new Vector3(1, 1, 1) * _scaleMax;
        _thisLight.intensity = 2.0f;
        _time = 0;
    }


    private void RandomWarp() {
        Random.InitState(Mathf.FloorToInt(1000 * (Time.time - Mathf.FloorToInt(Time.time)) * Random.value));
        float r = (Rmax - Rmin) * Random.value + Rmin;
        float h = (Hmax - Hmin) * Random.value + Hmin;
        float phi = 2 * Mathf.PI * Random.value;
        float x = r * Mathf.Cos(phi);
        float y = h;
        float z = r + Mathf.Sin(phi);
        transform.position = new Vector3(x,y,z);
    }
    private void Clear() {
        Debug.Log("Clear");
        _isClear = true;
        _thisLight.type = LightType.Spot;
        _thisLight.intensity = 4.0f;
        AreaParticles.SetActive(false);
        SpotParticle.SetActive(true);
        transform.LookAt(Door.transform);
        Door.SetActive(true);
    }
}
