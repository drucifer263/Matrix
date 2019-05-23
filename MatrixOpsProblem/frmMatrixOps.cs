using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOpsProblem
{
    public partial class frmMatrixOps : Form
    {
        public frmMatrixOps()
        {
            InitializeComponent();
        }

        /*
      Drew Watson
      Jupin
      Component based
      Fall 17
      MatrixOPS 
      Assignment 1
       */

        private double[,] matrixA;
        private double[,] matrixB;
        private double[,] matrixC;
        private int cols = 0,rows = 0;

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {
            try
            {
                rows = Convert.ToInt32(txtRowsA.Text);
                cols = Convert.ToInt32(txtColsA.Text);

                
                    matrixA = new double[rows, cols];

               
                    MakeMatrix(matrixA);
                    ConvertMatrixToBox(matrixA, txtMatrixA);
               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
            }
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            try
            {
                rows = Convert.ToInt32(txtRowsB.Text);
                cols = Convert.ToInt32(txtColsB.Text);

               
                    matrixB = new double[rows, cols];


                    MakeMatrix(matrixB);
                    ConvertMatrixToBox(matrixB, txtMatrixB);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
            }
        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            if (IsNotNull(matrixB) && IsNotEmpty(txtMatrixB))
            {
                int rowsIden = matrixB.GetLength(0), colsIden = matrixB.GetLength(1);

                if (CorrectRowsNCols(matrixB))
                {
                    matrixB = new double[rowsIden, colsIden];
                    for (int i = 0; i < rowsIden; i++)
                    {
                        for (int j = 0; j < colsIden; j++)
                        {
                            if (i == j)
                            {
                                matrixB[i, j] = 1.0;
                            }
                        }
                    }

                    ConvertMatrixToBox(matrixB, txtMatrixB);
                }

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNotEmpty(txtMatrixA) && IsNotEmpty(txtMatrixB))
                {
                    if (rdbMultiply.Checked == true)
                    {
                        MultiMatrix();
                    }

                    else if (rdbAdd.Checked == true)
                    {
                        AddMatrix();
                    }

                    else if (rdbSubtract.Checked == true)
                    {
                        SubtractMatrix();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
            }

        }

        private void AddMatrix()
        {
            int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1), 
                rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1);



            if (CorrectRowsAddSub(matrixA, matrixB) && IsNotNull(matrixA,matrixB))
            {
                matrixC = new double[rowsA, colsA];

                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsA; j++)
                    {
                       
                        matrixC[i,j] = matrixA[i, j] + matrixB[i,j];
                        
                    }
                }

                ConvertMatrixToBox(matrixC, txtMatrixC);
            }
        }

        private void SubtractMatrix()
        {
            int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1),
                rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1);



            if (CorrectRowsAddSub(matrixA, matrixB) && IsNotNull(matrixA,matrixB))
            {
                matrixC = new double[rowsA, colsA];

                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsA; j++)
                    {

                        matrixC[i, j] = matrixA[i, j] - matrixB[i, j];

                    }
                }

                ConvertMatrixToBox(matrixC, txtMatrixC);
            }
        }

        private void MultiMatrix()
        {
            int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1),
                rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1),
                rowsC =rowsA, colsC=colsB;



            if (CorrectRowsNColsMulti(matrixA, matrixB) && IsNotNull(matrixA, matrixB))
            {
                matrixC = new double[rowsA, colsB];
                
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        for (int k = 0; k < colsA; k++)
                        {
                            
                          matrixC[i, j] += matrixA[i,k] * matrixB[k,j];
                            
                        }
                    }
                }

                ConvertMatrixToBox(matrixC, txtMatrixC);
            }

        }

        private void btnClearMatrices_Click(object sender, EventArgs e)
        {
            double[,] cleared = new double[rows,cols];
            try
            {
            /*double[,] matrixA = new double[rows,cols];
            double[,] matrixB = new double[rows, cols];
            double[,] matrixC = new double[rows, cols];*/
            Array.Copy(cleared, matrixA, cleared.Length);
            Array.Copy(cleared, matrixB, cleared.Length);
            //Array.Copy(cleared, matrixC, cleared.Length);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
            }
            
             
            
            

            txtMatrixA.Text ="";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeMatrix(double [,] matrix)
        {
            Random autoRand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = autoRand.NextDouble() * 10.0;
                }
            }

        }

        private  void ConvertMatrixToBox(double[,] matrix, TextBox txtBox)
        {
            string matrixConvert="";
            string buffer = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrixConvert += matrix[i, j].ToString("f1") + "\t";
                }
                //matrixConvert += "\n";
            }

            //int j = 0, k = 0;

            //for (k = j + 1; k < matrix.GetLength(0); k++)
            //{
            //    for (j = 0; j < matrix.GetLength(1) ; j++)
            //    {
            //        matrixConvert += matrix[k, j].ToString("f1") + "\t";
            //    }
            //    matrixConvert += "\n";
            //}

            txtBox.Text = matrixConvert;
            
        }

        private void IsValid()
        {

        }

        private bool CorrectRowsAddSub(double [,] matrixA, double[,] matrixB)
        {
            bool correctRowsNCols = false;
            int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1),
                rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1);
           

            if (rowsA == rowsB && colsA == colsB)
            {
                correctRowsNCols = true;
            }

            else
            {
                MessageBox.Show("Matrix A has to be the same dimensions as  Matrix B");
            }

            return correctRowsNCols;
        }
        private bool CorrectRowsNColsMulti(double[,] matrixA, double[,] matrixB)
        {
            bool correctRowsNColsMulti = false;
            int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1),
                rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1);


            if (rowsA == colsB && colsA == rowsB)
            {
                correctRowsNColsMulti = true;
            }

            else
            {
                MessageBox.Show("Matrix A rows has to be equal to Matrix B cols or vice versa and not null");
            }

            return correctRowsNColsMulti;
        }

        private bool CorrectRowsNCols(double[,] matrix)
        {
            bool correctRowsNCols = false;
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
               


            if (rows == cols )
            {
                correctRowsNCols = true;
            }

            else
            {
                MessageBox.Show("The Matrix does not have equal dimensions");

            }

            return correctRowsNCols;
        }

        private bool IsNotNull(double [,] matrix)
        {
            bool isNotNull = false; 

            if(matrix != null )
            {
                isNotNull = true;
            }

            else
            {
                MessageBox.Show("The Matrix  cannot be null");
                
            }

            return isNotNull;
        }

        private bool IsNotNull(double[,] matrixA, double [,] matrixB)
        {
            bool isNotNull = false;

            if (matrixA != null && matrixB != null)
            {
                isNotNull = true;
            }

            else
            {
                MessageBox.Show("Matrix A and B cannot be null");
                //isNotNull = false;
            }

            return isNotNull;
        }
        private bool IsNotEmpty(TextBox textBox)
        {
            bool isNotEmpty;

            if (txtMatrixB.Text != "")
            {
                isNotEmpty = true;
            }

            else
            {
                MessageBox.Show("You have to make a matrix");
                isNotEmpty = false;
            }

            return isNotEmpty;
        }
        private void frmMatrixOps_Load(object sender, EventArgs e)
        {
            rows = 3;
            cols = 3;

            txtColsA.Text = Convert.ToString(cols);
            txtRowsA.Text = Convert.ToString(rows);
            txtColsB.Text = Convert.ToString(cols);
            txtRowsB.Text = Convert.ToString(rows);

            rdbMultiply.Checked = true;
        }
    }
}
