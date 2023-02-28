using System;
using UnityEngine;

public class Fire : MonoBehaviour {
    private AudioSource _as;
    public ParticleSystem _ps;
    public Camera cam;
    
    
    private void Start() {
        _as = GetComponent<AudioSource>();
    }

    private void Update() {

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
            _as.Play();
            _ps.Play();
            Invoke("StopParticles",0.5f);
        }
    }

    void StopParticles() {
        _ps.Stop();
    }
    void Shoot() {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hitData;
        Physics.Raycast(ray, out hitData);
        if (hitData.collider == null) return;
        if (hitData.collider.tag == "Target") {
            Destroy(hitData.collider.gameObject);
            GameManager.Instance.IncrementScore();
        }
    }
}
