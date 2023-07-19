using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single 6 sided die (1 - 6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The current face up value of the die 
        /// </summary>
        public byte FaceValue { get; set; }
        
        /// <summary>
        /// True if the die is currently held 
        /// </summary>
        public bool isHeld { get; set; }
       
        /// <summary>
        /// Rolls die and sets the <see cref="FaceValue"/> 
        /// to the new number 
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            // Generate random number + set to the face vallue
            // Return a new number 
            throw new NotImplementedException();
        }
    }
}
