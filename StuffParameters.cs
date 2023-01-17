using System;

namespace WPF
{
    public class StuffParameters
    {
        private StuffType _stuffType;
        private PetType _petType;
        private Enum _firstPar;
        private Enum _secondPar;

        public StuffType StuffType
        {
            get { return _stuffType; }
        }
        
        public PetType PetType
        {
            get { return _petType; }
        }
        
        public Enum First
        {
            get { return _firstPar; }
        }
        
        public Enum Second
        {
            get { return _secondPar; }
        }

        public StuffParameters(StuffType stfType, PetType pType, Enum first, Enum second)
        {
            _stuffType = stfType;
            _petType = pType;
            _firstPar = first;
            _secondPar = second;
        }
    }
}