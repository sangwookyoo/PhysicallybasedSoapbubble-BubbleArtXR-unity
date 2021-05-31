using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour
{
    //비눗방울이 발사되는 파티클 개체  
    public ParticleSystem particleLauncher;

    //발사된 비눗방울개체가 충돌될때 호출되는 충돌반응 이펙트
    public ParticleSystem splatterParticles;

    //충돌하는 이벤트들을 저장할 , 파티클 이벤트 저장 리스트 
    List<ParticleCollisionEvent> collisionEvents;
    public Gradient particleColorGradient;

    public void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
    }
    //유니티에서 미리 제공되는 이벤트 수신 함수로써,파티클 충돌이 벤트를 감지한다.
    void OnParticleCollision(GameObject other)
    {
        //해당 파티클 시스템의 이벤트를 감지하고, 이벤트 관련정보를 해당 리스트에 충돌시마다 재할당한다.
        ParticlePhysicsExtensions.GetCollisionEvents(particleLauncher, other, collisionEvents);

        //각각의 파티클 이벤트에 접근해, 해당 포지션에서 파티클을 에미트 시킨다.
        for (int i = 0; i < collisionEvents.Count; i++)
        {
            EmitAtLocation(collisionEvents[i]);
        }
    }
    void EmitAtLocation(ParticleCollisionEvent particleCollisionEvent)
    {
        //파티클의 위치와 로테이션값을 직접 접근해서 수정가능.
        splatterParticles.transform.position = particleCollisionEvent.intersection;//이벤트에 교차점 정보 
        //이벤트에 , 충돌한 개체의 노말 벡터 방향 정보를 가진다.
        splatterParticles.transform.rotation = Quaternion.LookRotation(particleCollisionEvent.normal);

        //색상은 직접 변경할수 없기때문에, 아래와 같이 간접 접근을 통해변경한다.
        ParticleSystem.MainModule psMain = splatterParticles.main;
        psMain.startColor = particleColorGradient.Evaluate(Random.Range(0f, 1f));

        //하나의 이벤트에대해 하나의 파티클만 에미트 
        splatterParticles.Emit(1);
    }
    //마우스 인풋을 통해 파티클을 발사하는 함수 
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            //제어 하고자 하는 파티클에 접근해, 속성을 변화 시키는 방식
            ParticleSystem.MainModule psMain = particleLauncher.main;
            psMain.startColor = Color.red;
            //비눗방울 파티클 발사 
            particleLauncher.Emit(1);
        }
    }
}