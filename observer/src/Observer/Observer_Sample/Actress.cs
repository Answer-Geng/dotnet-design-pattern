﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Sample
{
    public class Actress
    {
        private List<Observer> _observers = new List<Observer>();
        private int _state;
        public int GetState()
        {
            return _state;
        }
        public void SetState(int state)
        {
            _state = state;
            Notify();
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.LightCigarette();
            }
        }
        public void Attach(Observer observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }
        public void Detach(Observer observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
    }
}
