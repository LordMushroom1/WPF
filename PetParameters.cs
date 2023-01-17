using System;

namespace WPF
{
    public class PetParameters
    {
        private Enum _breedType;
        private Size _sizeType;
        private Age _ageType;
        private VaccineType _vaccineType;

        public Enum BreedType
        {
            get { return _breedType; }
        }
        
        public Size SizeType
        {
            get { return _sizeType; }
        }
        
        public Age AgeType
        {
            get { return _ageType; }
        }
        
        public VaccineType VaccineType
        {
            get { return _vaccineType; }
        }

        public PetParameters(Enum breedType, Size size, Age age, VaccineType vaccine)
        {
            _breedType = breedType;
            _sizeType = size;
            _ageType = age;
            _vaccineType = vaccine;
        }
    }
}