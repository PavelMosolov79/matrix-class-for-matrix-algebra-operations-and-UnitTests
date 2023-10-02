using Lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void AddMatrix()
        {

            int[,] data1 = { { 1, 2 }, { 3, 4 } };
            int[,] data2 = { { 2, 1 }, { 4, 3 } };
            Matrix matrix1 = new Matrix(data1);
            Matrix matrix2 = new Matrix(data2);
            int[,] expectedData1 = { { 3, 3 }, { 7, 7 } };
            Matrix expectedMatrix1 = new Matrix(expectedData1);

            Matrix resultMatrix1 = matrix1 + matrix2;
            Assert.AreEqual(expectedMatrix1, resultMatrix1);


            int[,] data3 = { { -1, -2 }, { -3, -4 } };
            int[,] data4 = { { -2, -1 }, { -4, -3 } };
            Matrix matrix3 = new Matrix(data3);
            Matrix matrix4 = new Matrix(data4);
            int[,] expectedData2 = { { -3, -3 }, { -7, -7 } };
            Matrix expectedMatrix2 = new Matrix(expectedData2);

            Matrix resultMatrix2 = matrix3 + matrix4;
            Assert.AreEqual(expectedMatrix2, resultMatrix2);


            int[,] data5 = { { 1, 2 }, { 3, 4 } };
            int[,] data6 = { { 2, 1, 3 }, { 4, 3, 5 } };
            Matrix matrix5 = new Matrix(data5);
            Matrix matrix6 = new Matrix(data6);

            Assert.ThrowsException<InvalidOperationException>(() => matrix5 + matrix6);
        }

        [TestMethod]
        public void SubMatrix()
        {
            int[,] data1 = { { 5, 4 }, { 3, 2 } };
            int[,] data2 = { { 1, 2 }, { 3, 4 } };
            Matrix matrix1 = new Matrix(data1);
            Matrix matrix2 = new Matrix(data2);
            int[,] expectedData1 = { { 4, 2 }, { 0, -2 } };
            Matrix expectedMatrix1 = new Matrix(expectedData1);

            Matrix resultMatrix1 = matrix1 - matrix2;
            Assert.AreEqual(expectedMatrix1, resultMatrix1);


            int[,] data3 = { { -1, -2 }, { -3, -4 } };
            int[,] data4 = { { -2, -1 }, { -4, -3 } };
            Matrix matrix3 = new Matrix(data3);
            Matrix matrix4 = new Matrix(data4);
            int[,] expectedData2 = { { 1, -1 }, { 1, -1 } };
            Matrix expectedMatrix2 = new Matrix(expectedData2);

            Matrix resultMatrix2 = matrix3 - matrix4;
            Assert.AreEqual(expectedMatrix2, resultMatrix2);

 
            int[,] data5 = { { 1, 2 }, { 3, 4 } };
            int[,] data6 = { { 2, 1, 3 }, { 4, 3, 5 } };
            Matrix matrix5 = new Matrix(data5);
            Matrix matrix6 = new Matrix(data6);

            Assert.ThrowsException<InvalidOperationException>(() => matrix5 - matrix6);
        }

        [TestMethod]
        public void MulMatrix()
        {
            int[,] data1 = { { 1, 2 }, { 3, 4 } };
            int[,] data2 = { { 2, 0 }, { 1, 2 } };
            Matrix matrix1 = new Matrix(data1);
            Matrix matrix2 = new Matrix(data2);
            int[,] expectedData1 = { { 4, 4 }, { 10, 8 } };
            Matrix expectedMatrix1 = new Matrix(expectedData1);

            Matrix resultMatrix1 = matrix1 * matrix2;
            Assert.AreEqual(expectedMatrix1, resultMatrix1);


            int[,] data3 = { { -1, -2 }, { -3, -4 } };
            int[,] data4 = { { -2, -1 }, { -4, -3 } };
            Matrix matrix3 = new Matrix(data3);
            Matrix matrix4 = new Matrix(data4);
            int[,] expectedData2 = { { 10, 7 }, { 22, 15 } };
            Matrix expectedMatrix2 = new Matrix(expectedData2);

            Matrix resultMatrix2 = matrix3 * matrix4;
            Assert.AreEqual(expectedMatrix2, resultMatrix2);
        }

        [TestMethod]
        public void EqualMatrix()
        {
            int[,] data1 = { { 1, 2 }, { 3, 4 } };
            Matrix matrix1 = new Matrix(data1);
            Matrix matrix2 = new Matrix(data1);

            Assert.IsTrue(matrix1 == matrix2);


            int[,] data2 = { { 2, 1 }, { 4, 3 } };
            Matrix matrix3 = new Matrix(data2);

            Assert.IsFalse(matrix1 == matrix3);


            Matrix matrix4 = null;
            Assert.IsFalse(matrix1 == matrix4);
        }

        [TestMethod]
        public void TransposeMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix matrix1 = new Matrix(data1);
            int[,] expectedData1 = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            Matrix expectedMatrix1 = new Matrix(expectedData1);

            Matrix resultMatrix1 = matrix1.Transpose();
            Assert.AreEqual(expectedMatrix1, resultMatrix1);


            int[,] data2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix2 = new Matrix(data2);
            int[,] expectedData2 = { { 1, 4 }, { 2, 5 }, { 3, 6 } };
            Matrix expectedMatrix2 = new Matrix(expectedData2);

            Matrix resultMatrix2 = matrix2.Transpose();
            Assert.AreEqual(expectedMatrix2, resultMatrix2);
        }

        [TestMethod]
        public void MinMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix1 = new Matrix(data1);
            int min1 = matrix1.Min();
            Assert.AreEqual(1, min1);

            int[,] data2 = { { -1, -2, -3 }, { -4, -5, -6 } };
            Matrix matrix2 = new Matrix(data2);
            int min2 = matrix2.Min();
            Assert.AreEqual(-6, min2);

            int[,] data3 = { { 0, 0, 0 }, { 0, 0, 0 } };
            Matrix matrix3 = new Matrix(data3);
            int min3 = matrix3.Min();
            Assert.AreEqual(0, min3);

            int[,] data4 = { { 10 } };
            Matrix matrix4 = new Matrix(data4);
            int min4 = matrix4.Min();
            Assert.AreEqual(10, min4);

            int[,] data5 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Matrix matrix5 = new Matrix(data5);
            int min5 = matrix5.Min();
            Assert.AreEqual(1, min5);
        }

        [TestMethod]
        public void StrMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix1 = new Matrix(data1);
            string str1 = matrix1.ToString();
            string expectedStr1 = "{{1, 2, 3}, {4, 5, 6}}";
            Assert.AreEqual(expectedStr1, str1);

            int[,] data2 = { { -1, -2 }, { -3, -4 } };
            Matrix matrix2 = new Matrix(data2);
            string str2 = matrix2.ToString();
            string expectedStr2 = "{{-1, -2}, {-3, -4}}";
            Assert.AreEqual(expectedStr2, str2);

            int[,] data3 = { { 0, 0 }, { 0, 0 } };
            Matrix matrix3 = new Matrix(data3);
            string str3 = matrix3.ToString();
            string expectedStr3 = "{{0, 0}, {0, 0}}";
            Assert.AreEqual(expectedStr3, str3);

            int[,] data4 = { { 10 } };
            Matrix matrix4 = new Matrix(data4);
            string str4 = matrix4.ToString();
            string expectedStr4 = "{{10}}";
            Assert.AreEqual(expectedStr4, str4);

            int[,] data5 = { { 1, 2 }, { 3, 4 } };
            Matrix matrix5 = new Matrix(data5);
            string str5 = matrix5.ToString();
            string expectedStr5 = "{{1, 2}, {3, 4}}";
            Assert.AreEqual(expectedStr5, str5);
        }

        [TestMethod]
        public void IndexMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix1 = new Matrix(data1);
            int element1_1 = matrix1[0, 0];
            int element1_2 = matrix1[0, 1];
            int element1_3 = matrix1[0, 2];
            int element1_4 = matrix1[1, 0];
            int element1_5 = matrix1[1, 1];
            int element1_6 = matrix1[1, 2];

            Assert.AreEqual(1, element1_1);
            Assert.AreEqual(2, element1_2);
            Assert.AreEqual(3, element1_3);
            Assert.AreEqual(4, element1_4);
            Assert.AreEqual(5, element1_5);
            Assert.AreEqual(6, element1_6);

            int[,] data2 = { { -1, -2, -3 }, { -4, -5, -6 } };
            Matrix matrix2 = new Matrix(data2);
            int element2_1 = matrix2[0, 0];
            int element2_2 = matrix2[0, 1];
            int element2_3 = matrix2[0, 2];
            int element2_4 = matrix2[1, 0];
            int element2_5 = matrix2[1, 1];
            int element2_6 = matrix2[1, 2];

            Assert.AreEqual(-1, element2_1);
            Assert.AreEqual(-2, element2_2);
            Assert.AreEqual(-3, element2_3);
            Assert.AreEqual(-4, element2_4);
            Assert.AreEqual(-5, element2_5);
            Assert.AreEqual(-6, element2_6);
        }

        [TestMethod]
        public void NumIMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix1 = new Matrix(data1);
            int rows1 = matrix1.I;
            Assert.AreEqual(2, rows1);

            int[,] data2 = { { -1, -2, -3 }, { -4, -5, -6 }, { -7, -8, -9 } };
            Matrix matrix2 = new Matrix(data2);
            int rows2 = matrix2.I;
            Assert.AreEqual(3, rows2);

            int[,] data3 = { { 0, 0, 0 } };
            Matrix matrix3 = new Matrix(data3);
            int rows3 = matrix3.I;
            Assert.AreEqual(1, rows3);

            int[,] data4 = { { 10 } };
            Matrix matrix4 = new Matrix(data4);
            int rows4 = matrix4.I;
            Assert.AreEqual(1, rows4);
        }

        [TestMethod]
        public void NumJMatrix()
        {
            int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix matrix1 = new Matrix(data1);
            int columns1 = matrix1.J;
            Assert.AreEqual(3, columns1);

            int[,] data2 = { { -1, -2 }, { -3, -4 }, { -5, -6 } };
            Matrix matrix2 = new Matrix(data2);
            int columns2 = matrix2.J;
            Assert.AreEqual(2, columns2);

            int[,] data3 = { { 0 } };
            Matrix matrix3 = new Matrix(data3);
            int columns3 = matrix3.J;
            Assert.AreEqual(1, columns3);

            int[,] data4 = { { 10, 20, 30, 40 } };
            Matrix matrix4 = new Matrix(data4);
            int columns4 = matrix4.J;
            Assert.AreEqual(4, columns4);
        }
    }
}