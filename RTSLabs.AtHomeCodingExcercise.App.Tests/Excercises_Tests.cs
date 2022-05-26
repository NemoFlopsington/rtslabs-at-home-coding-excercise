namespace RTSLabs.AtHomeCodingExcercise.App.Tests
{
    [TestClass]
    public class Excercises_Tests
    {
        [TestMethod]
        public void aboveBelow_Valid()
        {
            //Arrange
            var collection = new List<int>();
            const int comparison = 5;
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(5);
            collection.Add(6);
            collection.Add(7);
            collection.Add(8);

            //Act
            var aboveBelowVar = Excercises.aboveBelow(collection, comparison);

            //Assert
            Assert.AreEqual(3, aboveBelowVar["above"]);
            Assert.AreEqual(3, aboveBelowVar["below"]);
        }

        [TestMethod]
        public void aboveBelow_EmptyCollection()
        {
            //Arrange
            var collection = new List<int>();
            const int comparison = 5;

            //Act
            var aboveBelowVar = Excercises.aboveBelow(collection, comparison);

            //Assert
            Assert.AreEqual(0, aboveBelowVar["above"]);
            Assert.AreEqual(0, aboveBelowVar["below"]);
        }


        [TestMethod]
        public void stringRotation_Valid()
        {
            //Arrange
            var originalString = "Hello World";
            const int rotationAmount = 3;

            //Act
            var rotatedString = Excercises.stringRotation(originalString, rotationAmount);

            //Assert
            Assert.AreEqual("rldHello Wo", rotatedString);
        }

        [TestMethod]
        public void stringRotation_ExtraRotationAmount()
        {
            //Arrange
            const string originalString = "Hello World";
            const int rotationAmount = 14;

            //Act
            var rotatedString = Excercises.stringRotation(originalString, rotationAmount);

            //Assert
            Assert.AreEqual("rldHello Wo", rotatedString);
        }

        [TestMethod]
        public void stringRotation_EmptyString()
        {
            //Arrange
            var originalString = "";
            const int rotationAmount = 5;

            //Act
            var rotatedString = Excercises.stringRotation(originalString, rotationAmount);

            //Assert
            Assert.AreEqual("", rotatedString);
        }


        [TestMethod]
        public void stringRotation_NegativeRotation()
        {
            try
            {
                //Arrange
                var originalString = "Hello World";
                const int rotationAmount = -3;

                //Act
                var rotatedString = Excercises.stringRotation(originalString, rotationAmount);

                //Assert
                Assert.IsTrue(false);
            }
            catch (ArgumentException e)
            {
                //Assert
                Assert.AreEqual("rotationAmount must be positive", e.Message);
            }
            catch(Exception)
            {
                //Assert
                Assert.IsTrue(false);
            }
            

        }
    }
}