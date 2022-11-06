using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{

    public class ShadowMovement : MonoBehaviour
    {
        private CharacterController _controller;
        public GameObject PlayerObject;
        FirstPersonController Player;



        IEnumerator Start()
        {


            yield return new WaitForSeconds(4f);

            _controller = GetComponent<CharacterController>();
            Player = PlayerObject.GetComponent<FirstPersonController>();
            Debug.Log(Player.referenceMovement);

        }

       // Start is called before the first frame update
       // void Start()
        //{

       // }

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(PlayerObject.transform);
            _controller.Move(Player.buffer[0]);
            Player.buffer.RemoveAt(0);
        }
    }

}