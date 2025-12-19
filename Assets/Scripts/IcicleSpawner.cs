using UnityEngine;

public class IcicleSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _icicle;

        private float _timer;

    private void Start()
    {
        SpawnIcicle();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnIcicle();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
    private void SpawnIcicle()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject icicle = Instantiate(_icicle, spawnPos, Quaternion.identity);

        Destroy(icicle, 10f);
    }
}
