using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Machinegun
    {
        private double _RateOfFire = 0.1;
        private double _Misfires = 0.1;
        private int _MaxCountOfRoundsInStore = 10;
        private int _CountOfRoundsInStore;
        private Random random;
        private bool _isPullTrigger = false;
        private double overheating = 0;
        private double _CriticalOverheating = 2;

        public IState State;

        /// <summary>
        /// Скорость стрельбы в секунду
        /// </summary>
        public double RateOfFire
        {
            get => _RateOfFire;
            set => _RateOfFire = value > 0 ? value : _RateOfFire;
        }
        /// <summary>
        /// Вероятность от 0 до 1, что случиться осечка и оружие заклинит
        /// </summary>
        public double Misfires
        {
            get => _Misfires = 0;
            set => _Misfires = 0 <= value && value <= 1 ? value : _Misfires;
        }
        /// <summary>
        /// Максимальное кол-во патрон в магазине
        /// </summary>
        public int MaxCountOfRoundsInStore
        {
            get => _MaxCountOfRoundsInStore;
            set => _MaxCountOfRoundsInStore = value > 0 ? value : _MaxCountOfRoundsInStore;
        }
        /// <summary>
        /// Кол-во патрон в магазине
        /// </summary>
        public int CountOfRoundsInStore => _CountOfRoundsInStore;
        /// <summary>
        /// Критическая отметка перегрева
        /// </summary>
        public double CriticalOverheating
        {
            get => _CriticalOverheating;
            set => _CriticalOverheating = value > 0 ? value : _CriticalOverheating;
        }
        /// <summary>
        /// Стреляет ли оружие в данный момент
        /// </summary>
        public bool isPullTrigger => _isPullTrigger;


        public delegate void eventFunction();
        public event eventFunction? UpdateState;

        public Machinegun() : this(0) { }
        public Machinegun(int seed)
        {
            State = new StateReady(this);
            random = new Random(seed);
            _CountOfRoundsInStore = MaxCountOfRoundsInStore;
        }

        public void CallEvent() => UpdateState?.Invoke();

        public void Shooting()
        {
            if (CountOfRoundsInStore > 0 && State.GetType() == typeof(StateShooting))
            {
                if (random.NextDouble() <= Misfires && Misfires != 0)
                {
                    State = new StateJammed(this);
                    CallEvent();
                }
                else
                {
                    _CountOfRoundsInStore--;
                    if (CountOfRoundsInStore == 0)
                    {
                        State = new StateOutOfAammoInStore(this);
                        CallEvent();
                    }
                    else
                    {
                        overheating += random.NextDouble();
                        if (overheating > CriticalOverheating)
                        {
                            State = new StateOverheating(this);
                            CallEvent();
                        }
                    }
                }
            }
            else
            {
                if(overheating > 0)
                {
                    overheating -= random.NextDouble();
                    if(overheating < 0)
                    {
                        overheating = 0;
                        State = new StateReady(this);
                        CallEvent();
                    }
                }
            }
        }

        public void PullTrigger() 
        {
            if(State.GetType() == typeof(StateReady) && CountOfRoundsInStore > 0)
            {
                _isPullTrigger = true;
                State = new StateShooting(this);
                CallEvent();
            }
        }
        public void ReleaseTrigger() 
        {
            _isPullTrigger = false;
            if (State.GetType() == typeof(StateShooting))
            {
                State = new StateReady(this);
                CallEvent();
            }
        }
        public bool Recharge() 
        {
            if(!isPullTrigger)
            {
                _CountOfRoundsInStore = MaxCountOfRoundsInStore;
                return true;
            }
            return false;
        }
    }
}
