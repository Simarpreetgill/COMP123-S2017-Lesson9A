using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July11,2017
 * Description-This is the SuperHuman sub class
 * Version- 0.2 - Added Private Initialize Method
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the SuperHuman Sub Class
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FILEDS
        private List<Power> _powers;
        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        // PUBLIC METHODS
    }
}
