using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoSat_Dashboard
{
    public class Model : IObservable<Dashboard>
    {
        private Dashboard Data = null;  //hält die aktuellen Dashboard bereit

        private List<IObserver<Dashboard>> observers = null; //wird die Liste der zu benachrichtigenden Observer

        public Model()
        {
            observers = new List<IObserver<Dashboard>>();    //Erzeugen einer leeren Liste
        }

        public void DataReceived(string receivedData)
        {
            Data = new Dashboard(receivedData);                 //neue Zahlen generieren

            foreach (IObserver<Dashboard> observer in observers)
                observer.OnNext(Data);
        }
        //ab hier IObservable
        public IDisposable Subscribe(IObserver<Dashboard> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Dashboard>> _observers;
            private IObserver<Dashboard> _observer;

            public Unsubscriber(List<IObserver<Dashboard>> observers, IObserver<Dashboard> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer)) _observers.Remove(_observer);

            }
        }

    }
}
