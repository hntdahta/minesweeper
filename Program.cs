using System;

public class Test
{
    public static int[][] minesweeper(bool[][] matrix)
    {
        int[][] result = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            result[i] = new int[matrix[0].Length];
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j])
                {
                    //Row Above
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0) result[i - 1][j - 1]++;
                        result[i - 1][j]++;
                        if (j + 1 < result[i].Length) result[i - 1][j + 1]++;
                    }
                    //Row
                    if (j - 1 >= 0) result[i][j - 1]++;
                    if (j + 1 < matrix[i].Length) result[i][j + 1]++;
                    //Row Below
                    if (i + 1 < matrix.Length)
                    {
                        if (j - 1 >= 0) result[i + 1][j - 1]++;
                        result[i + 1][j]++;
                        if (j + 1 < matrix[i].Length) result[i + 1][j + 1]++;
                    }
                }
            }
        }
        return result;
    }
    public static void Main()
    {
        bool[][] matrix = new bool[][]{
       new bool []{true, false, false},
             new bool []{false, true, false},
                new bool []{false, false, false}
      };
        var result = minesweeper(matrix);
        foreach (int[] i in result)
        {
            foreach (int j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}