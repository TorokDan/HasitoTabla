namespace HasitoTabla
{
    public class HasitoTabla
    {
        private string[] _tartalmak;

        public HasitoTabla()
        {
            _tartalmak = new string[26];
        }

        public void Beszuras(string orszagkod, string orszag)
        {
            char kezdobetu = orszagkod.ToUpper()[0];
            int index = (int) kezdobetu - (int)'A';
            _tartalmak[index] = orszag;
        }

        public string Kereses(string orszagkod)
        {
            char kezdobetu = orszagkod.ToUpper()[0];
            int index = (int) kezdobetu - (int)'A';
            return _tartalmak[index];
        }
    }
}