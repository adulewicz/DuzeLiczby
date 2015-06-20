using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuzeLiczby;

namespace Tests
{
    [TestClass]
    public class OperationTests
    {
        private const int NORMAL_NUMBER_OF_ELEMENTS = 1000;

        [TestMethod]
        public void Addition_BigTab()
        {
            Operation operation = new Operation(100000);
            operation.GenerateRandomValues();
            operation.Addition();

        }

        [TestMethod]
        public void IsFullyGeneratedTable()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            //spr czy wszystkie elementy w tablicy są zapełnione wartościami
            foreach (var elem in operation.ArrayOfIntegers)
            {
                Assert.IsNotNull(elem);
            }
        }

        [TestMethod]
        public void Division_DivByZero()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(0,1);
            
            var arr = operation.ArrayOfIntegers.Length;

            operation.Division();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void CanBeAddedMinus()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();
            operation.AddValue(-1);

        }

        [TestMethod]
        public void Multiplication_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1,1000);

            operation.Multiplication();

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Subtraction_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1,1000);

            operation.Subtraction();

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Division_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1,1000);

            operation.Division();
            Assert.IsFalse(operation.Logger.ErrorFlag);

        }

        [TestMethod]
        public void Addition_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            operation.Addition();
            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void AddIncorrectValue_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            operation.AddValue(10000000);
            operation.AddValue(int.Parse("EXAMPLE"));
            operation.AddValue((int)3.5);

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void MinusValues_Check()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(-9999, -999);

            operation.Addition();
            operation.Multiplication();
            operation.Subtraction();
            operation.Division();

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Addition_GoesManyTimes()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            for (int i = 0; i < 100; i++)
            {
                operation.Addition();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Division_GoesManyTimes()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            for (int i = 0; i < 100; i++)
            {
                operation.Division();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Multiplication_GoesManyTimes()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(0, 5000);

            int j = 0;

            foreach (var elem in operation.ArrayOfIntegers)
            {
                j++;
                if (elem == 0) 
                { 
                    operation.ArrayOfIntegers[j] = new Random().Next(1, 100); 
                }
            }

            for (int i = 0; i < 100; i++)
            {
                operation.Multiplication();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void Substraction_GoesManyTimes()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            for (int i = 0; i < 100; i++)
            {
                operation.Subtraction();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void AdditionAndMultiplication_Together()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(0,5000);

            int j = 0;

            foreach (var elem in operation.ArrayOfIntegers)
            {
                j++;
                if (elem == 0)
                {
                    operation.ArrayOfIntegers[j] = new Random().Next(1, 100);
                }
            }

            for (int i = 0; i < 100; i++)
            {
                operation.Addition();
                operation.Multiplication();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsArrayOfIntegersNull()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues();

            Assert.IsNotNull(operation.ArrayOfIntegers);
        }

        [TestMethod]
        public void DoubleValuesInsertedIntoTable()
        {
            Operation operation = new Operation(2);
            operation.GenerateRandomValues(0, (int)3.5);

            operation.AddValue((int)2.546456);
            operation.AddValue((int)-5.34546456);
            operation.AddValue((int)0.1111156);

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void MultiplicationAndDivision_Together()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1, 5000);

            int j = 0;

            foreach (var elem in operation.ArrayOfIntegers)
            {
                j++;
                if (elem == 0)
                {
                    operation.ArrayOfIntegers[j] = new Random().Next(1, 100);
                }
            }

            for (int i = 0; i < 100; i++)
            {
                operation.Multiplication();
                operation.Division();
            }

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsMessageListInitialized()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);

            Assert.IsNotNull(operation.Logger.Messages);

        }

        [TestMethod]
        public void IsErrorRaisedWhenNull_Addition()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1, 5000);

            operation.ArrayOfIntegers = null;

            operation.Addition();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsErrorRaisedWhenNull_Division()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1, 5000);

            operation.ArrayOfIntegers = null;

            operation.Division();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsErrorRaisedWhenNull_Multiplication()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1, 5000);

            operation.ArrayOfIntegers = null;

            operation.Multiplication();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsErrorRaisedWhenNull_Subtraction()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(1, 5000);

            operation.ArrayOfIntegers = null;

            operation.Subtraction();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsErrorRaisedWhenZero_Division()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(0,1);

            operation.Division();

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsErrorRaisedWhenZero_Multiplication()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(-500,50000);

            for (int i = 0; i < 100; i++) { operation.Multiplication(); }

            Assert.IsTrue(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void GenerateMinusValues()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);
            operation.GenerateRandomValues(-600, -200);

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsTabCapacity()
        {
            int tabCapacity = 100;
            Operation operation = new Operation(tabCapacity);
            operation.GenerateRandomValues();

            Assert.AreEqual(operation.ArrayOfIntegers.Length, tabCapacity); 
        }

        [TestMethod]
        public void IsValuesInTabCorrect()
        {
            int tabCapacity = 100;
            Operation operation = new Operation(tabCapacity);
            operation.GenerateRandomValues(100, 1000);

            foreach (var val in operation.ArrayOfIntegers)
            {
                if (val < 100 || val > 1000)
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void IsAllOperationPassed()
        {
            int tabCapacity = 100;
            Operation operation = new Operation(tabCapacity);
            operation.GenerateRandomValues(100, 1000);

            operation.Addition();
            operation.Division();
            operation.Multiplication();
            operation.Subtraction();

            Assert.IsFalse(operation.Logger.ErrorFlag);
        }

        [TestMethod]
        public void IsLoggerFlagsInitialized()
        {
            Operation operation = new Operation(NORMAL_NUMBER_OF_ELEMENTS);

            Assert.IsNotNull(operation.Logger.ErrorFlag);
            Assert.IsNotNull(operation.Logger.WarningFlag);

        }




    }
}
