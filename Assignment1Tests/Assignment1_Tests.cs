using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace Assignment1Tests
{
    [TestFixture]
    public class Assignment1_Tests
    {
       [Test]
        public void GetLength_Input9_ExpectLength_Equals9()
        {
            //Arrange
            int l = 9;
            int w = 3;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int length = testrectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void SetLength_Input6_ExpectLength_Equals6()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int length = testrectangle.SetLength(6);

            //Assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void GetWidth_Input4_ExpectWidth_Equals4()
        {
            //Arrange
            int l = 2;
            int w = 4;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }
        [Test]
        public void SetWidth_Input2_ExpectWidth_Equals2()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.SetWidth(2);

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void Parameter_Input_Length2_Input_Width2_ExpectParameter_Equals8()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int parameter = testrectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(parameter, 8);
        }
        [Test]
        public void Area_Input_Length1_Input_Width1_ExpectArea_Equals1()
        {
            //Arrange
            int l = 1;
            int w = 1;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int area = testrectangle.GetArea();

            //Assert
            Assert.AreEqual(area, 1);
        }
    }
}



