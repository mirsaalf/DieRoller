using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single 6 sided die (1 - 6)
    /// </summary>
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }
        /// <summary>
        /// Creates the die and rolls it to start
        /// with a random number 
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current face up value of the die 
        /// </summary>
        public byte FaceValue { get; private set; }
        
        /// <summary>
        /// True if the die is currently held 
        /// </summary>
        public bool isHeld { get; set; }
       
        /// <summary>
        /// Rolls die and sets the <see cref="FaceValue"/> 
        /// to the new number if die is not currently held
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            if (!isHeld)
            {
                // Generate random number
                byte newValue = (byte)_random.Next(1, 7);
            
                FaceValue = newValue;

            }
            return FaceValue;
        }
    }
}
