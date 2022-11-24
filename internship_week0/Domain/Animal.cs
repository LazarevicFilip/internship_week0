using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_week0.Domain
{
    internal abstract class Animal
    {
        private string _name;
        private float _weight;
        private string _furColor;

        protected Animal(string name, float weight, string furColor)
        {
            _name = name;
            _weight = weight;
            _furColor = furColor;
        }

        public string Name { 
            get => _name;
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _name = value;

            } 
        }
        public float Weight {
            get => _weight; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(value)); 
                }
                _weight = value;
            } 
        }
        public string FurColor
        {
            get => _furColor;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _furColor = value;

            }
        }
        protected abstract string Food { get;}

    }
}
