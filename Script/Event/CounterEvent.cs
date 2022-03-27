using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity.Event
{
    [System.SerializableAttribute]
    public class CountEventObject
    {
        public int count = 0;
        public UnityEngine.Events.UnityEvent events = new UnityEngine.Events.UnityEvent();
    }
    
    [System.SerializableAttribute]
    public class CounterDictionary : Object
    {
        public SortedDictionary<int, List<UnityEngine.Events.UnityEvent>> counter = new SortedDictionary<int, List<UnityEngine.Events.UnityEvent>>();
    }


    public class CounterEvent : MonoBehaviour
    {
        int nowCounter = 0;
        public int counter = 0;
        public bool loopFlg = false;

        [System.NonSerialized]
        int loopMaxCount = 0;

        public List<CountEventObject> countAction = new List<CountEventObject>();


        [SerializeField, HideInInspector]
        private CounterDictionary useCountAction = new CounterDictionary();

        public CounterDictionary countedAction
        {
            get { return useCountAction; }
            set
            {
                if (value == null) return;
                useCountAction = value;
            }
        }

        public int GetCount() { return counter; }

        public void SetCount(int _value) 
        {
            counter = _value > 0 ? _value : 0; 

            if(loopFlg)
            {
                counter = loopMaxCount - 1 > counter ? counter : loopMaxCount - 1;
            }
        }

        public void CountUp() 
        {
            counter++;

            if(loopFlg)counter %= loopMaxCount;
        }


        public void CountDown() 
        {
            counter--;

            if(counter < 0) counter = loopFlg ? loopMaxCount - 1 : 0;
        }

        // Start is called before the first frame update
        void Start()
        {

            nowCounter = counter;
            foreach (var actions in countAction)
            {
                if(!useCountAction.counter.ContainsKey(actions.count))
                {
                    useCountAction.counter[actions.count] = new List<UnityEngine.Events.UnityEvent>();
                }
                useCountAction.counter[actions.count].Add(actions.events);

                if (loopMaxCount < actions.count) loopMaxCount = actions.count;
            }

            loopMaxCount++;
        }

        // Update is called once per frame
        void Update()
        {
            if (counter == nowCounter) return;

            if (!useCountAction.counter.ContainsKey(counter)) return;

            foreach (var events in useCountAction.counter[counter])
            {
                events.Invoke();
            }

            nowCounter = counter;
        }
    }

}
