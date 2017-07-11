using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July11,2017
 * Description-This is the SuperHuman sub class
 * Version- 0.2 - Added Public AddPower Method
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
        public List<Power> Powers
        {
            get
            {
                return this._powers; //returns a reference to the Powers List
            }
        }
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
        /// <summary>
        /// This method adds a power to SuperHumans Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AdPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPowers()
        {
            foreach(var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name  + "Rank:"  + power.Rank);
                
            }
        }
    }
}
