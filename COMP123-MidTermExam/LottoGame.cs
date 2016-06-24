using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
       

       

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------
private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------
public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }

            set
            {
            }
        }

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

            set
            {
            }
        }

        public System.Random random
        {
            get
            {
                return this._random;
            }

            set
            {
            }
        }

        public int SetSize
        {
            get
            {
                return this._setSize;
            }

            set
            {
                this._setSize = value;
            }
        }
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 public LottoGame(int ElementNumber = 6,int setSize = 49)
        {
            throw new System.NotImplementedException();
        }

        
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------
 public void _initialize()
        {
            this.NumberList = new List<int>();
            this.ElementList = new List<int>();
            this.random = new Random();
        }
        // CREATE the private _build method here -----------------------------------
  public void _build()
        {
            for (int index = 0; index < SetSize; index++)
            {
                int number = index;
                this.NumberList.Add(number);
            }
            
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

      
 // CREATE the public PickElements method here ---------------------------
     public void PickElements()
        {for (int index = 0; index < ElementNumber; index++)
            {
                int number = random.Next(NumberList.Count);
                ElementList.Add(NumberList[number]);
                NumberList.Remove(number);
            }
                
            if (this.ElementList.Count >0)
            {
                
                this.ElementList.Clear();
                this.NumberList.Clear();
                _build();
                ElementList.Sort();

            
             };
               
            
        }
        
    }

        
}
