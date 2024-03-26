using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoSat_Dashboard
{
    public class Model : IObservable<SerialData>
    {
        private SerialData Data = null;  //hält die aktuellen SerialData bereit

        private List<IObserver<SerialData>> observers = null; //wird die Liste der zu benachrichtigenden Observer

        public Model()
        {
            observers = new List<IObserver<SerialData>>();    //Erzeugen einer leeren Liste
        }

        public void DataReceived(string receivedData)
        {
            Data = new SerialData(receivedData);                 //neue Zahlen generieren

            foreach (IObserver<SerialData> observer in observers)
                observer.OnNext(Data);
        }
        //ab hier IObservable
        public IDisposable Subscribe(IObserver<SerialData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<SerialData>> _observers;
            private IObserver<SerialData> _observer;

            public Unsubscriber(List<IObserver<SerialData>> observers, IObserver<SerialData> observer)
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
