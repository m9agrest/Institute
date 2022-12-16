using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public interface IState
    {
        public string Name { get; }
        public string Fix();
        public string Shoot();
        public string StopShoot();
    }
    public class StateOverheating : IState
    {
        public string Name => "Перегрев";
        private Machinegun machinegun;
        public StateOverheating(Machinegun machinegun) => this.machinegun = machinegun;
        public string Fix()
        {
            if (machinegun.isPullTrigger)
            {
                machinegun.ReleaseTrigger();
            }
            return "Ждите пока остынет";
        }
        public string Shoot() => machinegun.isPullTrigger ? 
            "Вы и так стреляете, но лучше остановитесь" : "Ждите пока остынет";
        public string StopShoot()
        {
            if(machinegun.isPullTrigger)
            {
                machinegun.ReleaseTrigger();
                return "Стрельба прекращена, подождите пока оружие остынет";
            }
            return "Оружие и так не стреляет";
        }
    }
    public class StateOutOfAammoInStore : IState
    {
        public string Name => "Патроны в магазине закончились";
        private Machinegun machinegun;
        public StateOutOfAammoInStore(Machinegun machinegun) => this.machinegun = machinegun;

        public string Fix()
        {
            if (machinegun.isPullTrigger)
            {
                machinegun.ReleaseTrigger();
            }
            machinegun.Recharge();
            machinegun.State = new StateReady(machinegun);
            machinegun.CallEvent();
            return "Вы можете возобновить стрельбу";
        }
        public string Shoot() => "В данный момент вы не можете стрелять";
        public string StopShoot()
        {
            if (machinegun.isPullTrigger)
            {
                machinegun.ReleaseTrigger();
                return "Вы отпустили курок";
            }
            return "В данный момент вы и так не стреляете";
        }
        
    }
    public class StateShooting : IState
    {
        public string Name => "Стрельба";
        private Machinegun machinegun;
        public StateShooting(Machinegun machinegun) => this.machinegun = machinegun;

        public string Fix() => "В данный момент всё работает";
        public string Shoot() => "Вы и так стреляете";
        public string StopShoot()
        {
            machinegun.ReleaseTrigger();
            return "Стрельба прекращена";
        }
    }
    public class StateReady : IState
    {
        public string Name => "Готово к использованию";
        private Machinegun machinegun;
        public StateReady(Machinegun machinegun) => this.machinegun = machinegun;
        public string Fix() => "В данный момент всё работает";
        public string Shoot()
        {
            machinegun.PullTrigger();
            return "Стрельба Начата";
        }
        public string StopShoot() => "Вы и так не стреляете";
    }
    public class StateJammed : IState
    {
        public string Name => "Готово к использованию";
        private Machinegun machinegun;
        public StateJammed(Machinegun machinegun) => this.machinegun = machinegun;
        public string Fix()
        {
            machinegun.ReleaseTrigger();
            machinegun.State = new StateReady(machinegun);
            machinegun.CallEvent();
            return "Вы можете возобновить стрельбу";
        }
        public string Shoot() => "Вы не можете стрелять";
        public string StopShoot() => Fix();
    }
}
