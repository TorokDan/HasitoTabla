using System;

namespace HasitoTabla
{
    public class HasitoTabla<K,T>
    {
        private T[] _tartalmak;

        public HasitoTabla()
        {
            _tartalmak = new T[13];
        }

        public T this[K kulcs]
        {
            get
            {
                return Kereses(kulcs);
            }
            set
            {
                Beszuras(kulcs, value);
            }
        }
        public void Beszuras(K kulcs, T tartalom)
        {
            int index = Math.Abs(kulcs.GetHashCode()) % 13;
            _tartalmak[index] = tartalom;
        }

        public T Kereses(K kulcs)
        {
            int index = Math.Abs(kulcs.GetHashCode()) % 13;
            return _tartalmak[index];
        }
    }
}