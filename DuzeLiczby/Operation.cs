using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzeLiczby
{
    public class Operation
    {
        #region Properties 

        public int[] ArrayOfIntegers;

        private int Capacity;

        public Logger Logger;

        #endregion


        #region Ctor

        public Operation(int tabCapacity)
        {
            if (tabCapacity > 0 && tabCapacity < int.MaxValue)
            {
                this.Capacity = tabCapacity;
                this.ArrayOfIntegers = new int[tabCapacity];
                this.Logger = new Logger();
            }
            else
            {
                throw new InvalidOperationException("Invalid capacity of array entered");
            }
        }

        #endregion

        public void GenerateRandomValues()
        {
            Random rnd = new Random();

            for (int i = 0; i < this.Capacity; i++)
            {
                this.ArrayOfIntegers[i] = rnd.Next();
            }
        }

        #region Operations
        /// <summary>
        /// Dodawanie wartości do tablicy
        /// </summary>
        /// <param name="value"></param>
        public void AddValue(int value)
        {
            var capacity = this.ArrayOfIntegers.Count();
            try
            {
                this.ArrayOfIntegers[capacity + 1] = checked(value);
            }
            catch (IndexOutOfRangeException)
            {
                this.Logger.Messages.Add(String.Format("Index out of range of array : {0}.", ArrayOfIntegers.Count()));
                this.Logger.ErrorFlag = true;
            }
            catch (Exception)
            {
                this.Logger.Messages.Add(String.Format("{0} value out of range of integer.", value));
                this.Logger.ErrorFlag = true;
            }
        }

        /// <summary>
        /// Dzielenie
        /// </summary>
        /// <param name="firstIndex">Indeks pierwszej liczby (w tablicy)</param>
        /// <param name="secondIndex">Indeks drugiej liczby (w tablicy)</param>
        /// <returns></returns>
        public List<string> Division()
        {
            List<string> results = new List<string>();
            int previousValue = 0;
            int actualVal = 0;

            try
            {
                foreach (var item in this.ArrayOfIntegers)
                {
                    actualVal = item;
                    results.Add(previousValue + " / " + item + " = " + checked(previousValue / item));
                    previousValue = item;
                }
            }
            catch (IndexOutOfRangeException)
            {
                this.Logger.Messages.Add(String.Format("Index out of range of array : {0}.", ArrayOfIntegers.Count()));
                this.Logger.ErrorFlag = true;
            }
            catch (DivideByZeroException)
            {
                this.Logger.Messages.Add(String.Format("Division by ZERO ! {0} / {1}.", previousValue, actualVal));
                this.Logger.ErrorFlag = true;
            }
            catch (Exception)
            {
                this.Logger.Messages.Add(String.Format("{0} or {1} value out of range of integer.", previousValue, actualVal));
                this.Logger.ErrorFlag = true;
            }

            return results;
        }

        /// <summary>
        /// Dodawanie
        /// </summary>
        /// <param name="firstIndex">Indeks pierwszej liczby (w tablicy)</param>
        /// <param name="secondIndex">Indeks drugiej liczby (w tablicy)</param>
        /// <returns></returns>
        public List<string> Addition()
        {
            List<string> results = new List<string>();
            int previousValue = 0;
            int actualVal = 0;

            try
            {
                foreach (var item in this.ArrayOfIntegers)
                {
                    actualVal = item;
                    results.Add(previousValue + " + " + item + " = " + checked(previousValue + item));
                    previousValue = item;
                }
            }
            catch (IndexOutOfRangeException)
            {
                this.Logger.Messages.Add(String.Format("Index out of range of array : {0}.", ArrayOfIntegers.Count()));
                this.Logger.ErrorFlag = true;
            }
            catch (Exception)
            {
                this.Logger.Messages.Add(String.Format("{0} or {1} value out of range of integer.", previousValue, actualVal));
                this.Logger.ErrorFlag = true;
            }

            return results;
        }

        /// <summary>
        /// Mnożenie
        /// </summary>
        /// <param name="firstIndex">Indeks pierwszej liczby (w tablicy)</param>
        /// <param name="secondIndex">Indeks drugiej liczby (w tablicy)</param>
        /// <returns></returns>
        public List<string> Multiplication()
        {
            List<string> results = new List<string>();
            int previousValue = 0;
            int actualVal = 0;

            try
            {
                foreach (var item in this.ArrayOfIntegers)
                {
                    actualVal = item;
                    results.Add(previousValue + " * " + item + " = " + checked(previousValue * item));
                    previousValue = item;
                }
            }

            catch (IndexOutOfRangeException)
            {
                this.Logger.Messages.Add(String.Format("Index out of range of array : {0}.", ArrayOfIntegers.Count()));
                this.Logger.ErrorFlag = true;
            }
            catch (Exception)
            {
                this.Logger.Messages.Add(String.Format("{0} or {1} value out of range of integer.", previousValue, actualVal));
                this.Logger.ErrorFlag = true;
            }

            return results;
        }

        /// <summary>
        /// Odejmowanie
        /// </summary>
        /// <param name="firstIndex">Indeks pierwszej liczby (w tablicy)</param>
        /// <param name="secondIndex">Indeks drugiej liczby (w tablicy)</param>
        /// <returns></returns>
        public List<string> Subtraction()
        {
            List<string> results = new List<string>();
            int previousValue = 0;
            int actualVal = 0;

            try
            {
                foreach (var item in this.ArrayOfIntegers)
                {
                    actualVal = item;
                    results.Add(previousValue + " - " + item + " = " + checked(previousValue - item));
                    previousValue = item;
                }
            }
            catch (IndexOutOfRangeException)
            {
                this.Logger.Messages.Add(String.Format("Index out of range of array : {0}.", this.Capacity));
                this.Logger.ErrorFlag = true;
            }
            catch (Exception)
            {
                this.Logger.Messages.Add(String.Format("{0} or {1} value out of range of integer.", previousValue, actualVal));
                this.Logger.ErrorFlag = true;
            }

            return results;
        }

        #endregion
    }
}
