using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name- Simar Gill
 * Date- July11,2017
 * Description-This is the abstract class human which other subclasses will derive from
 * Version- 0.1-Class created
 */


namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the human abstract class
    /// </summary>
    public abstract class Human
    {
        //PRIVATE FIELDS(INSTANCE VARIABLES)
        private string _name;
        // PUBLIC PROPERTIES----------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //CONSTRUCTORS-----------------------------------------------
        /// <summary>
        /// This is the constructor for the abstract class
        /// It requires one parameter - name
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
    }
}
