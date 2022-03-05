using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity.Common.Event
{

    public class CounterEvent : MonoBehaviour
    {
        ulong nowCounter = 0;
        ulong counter = 0;

        public ulong GetCount() { return counter; }

        public void SetCount(ulong _value) { counter = _value; }

        public void CountUp() { counter++; }

        public void CountDown() { counter = (counter <= 0) ? 0 : counter - 1; }



        public Dictionary<ulong , UnityEngine.Events.UnityEvent> countAction;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (counter == nowCounter) return;

            if (!countAction.ContainsKey(nowCounter)) return;

            countAction[nowCounter].Invoke();

            nowCounter = counter;
        }
    }

}