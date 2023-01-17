using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Breed
    {
        private Enum _breedType;
        private string _breedName;
        private double _averageWeight;
        private double _averageHeight;
        private double _maxHeight;
        private double _maxWidth;
        public Enum BreedType
        {
            get { return _breedType; }
        }
        public string BreedName
        {
            get { return _breedName; }
        }
        public double AverageWeight
        {
            get { return _averageWeight; }
        }
        public double AverageHeight
        {
            get { return _averageHeight; }
        }
        public double MaxHeight
        {
            get { return _maxHeight; }
        }
        public double MaxWidth
        {
            get { return _maxWidth; }
        }

        public Breed(Enum breedType,
                   string breedName,
                   double averageWeight,
                   double averageHeight,
                   double maxHeight,
                   double maxWidth)
        {
            _breedType = breedType;
            _breedName = breedName;
            _averageWeight = averageWeight;
            _averageHeight = averageHeight;
            _maxHeight = maxHeight;
            _maxWidth = maxWidth;

        }

    }
}
