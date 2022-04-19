using System;
using System.Collections.Generic;
using System.Linq;

namespace HasitoTabla
{
    public class HasitoTabla<K,T>
    {
        class HasitoElem
        {
            public K kulcs;
            public T tartalom;
        }

        public delegate int HasitoDelegalt(K kulcs);

        private HasitoDelegalt hasitoFuggveny;
        
        private List<HasitoElem>[] _tartalmak;

        private int Mod13(K kulcs)
        {
            return Math.Abs(kulcs.GetHashCode()) % 13;
        }

        public HasitoTabla(HasitoDelegalt hasitofv = null, int tombMeret = 13)
        {
            _tartalmak = new List<HasitoElem>[tombMeret];
            for (int i = 0; i < _tartalmak.Length; i++)
            {
                _tartalmak[i] = new List<HasitoElem>();
            }

            if (hasitofv != null)
            {
                hasitoFuggveny = hasitofv;
            }
            else
            {
                hasitoFuggveny = Mod13;
            }
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
            int index = hasitoFuggveny(kulcs);
            _tartalmak[index].Add(new HasitoElem()
            {
                kulcs = kulcs,
                tartalom = tartalom
            });
        }

        public T Kereses(K kulcs)
        {
            int index = hasitoFuggveny(kulcs);
            return LinearisKereses(kulcs, index);
        }

        private T LinearisKereses(K kulcs, int index)
        {
            int i = 0;
            while (i < _tartalmak[index].Count &&
                   !_tartalmak[index][i].kulcs.Equals(kulcs))
            {
                i++;
            }

            if (i < _tartalmak[index].Count)
            {
                return _tartalmak[index][i].tartalom;
            }
            else
            {
                throw new ArgumentException("Nincs ilyen kulcsó elem!");
            }
        }
    }
}