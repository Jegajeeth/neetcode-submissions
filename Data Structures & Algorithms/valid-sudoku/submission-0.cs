public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> rowHash = new();
        HashSet<char> colHash = new();
        Dictionary<string, HashSet<char>> squareCheck = new();
        char rowElement;
        char colElement;
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board.Length; j++)
            {
                rowElement = board[i][j];
                colElement = board[j][i];
                string rowSquare = (i/3 + "") + (j/3 + "");
                string colSquare = (j/3 + "") + (i/3 + "");
                if(!squareCheck.ContainsKey(rowSquare))
                {
                    squareCheck[rowSquare] = new HashSet<char>();
                }
                if(!squareCheck.ContainsKey(colSquare))
                {
                    squareCheck[colSquare] = new HashSet<char>();
                }
                if(rowElement != '.')
                {
                    if(!(rowHash.Add(rowElement)))
                    {
                        return false;
                    }
                    if(i < j && (!(squareCheck[rowSquare].Add(rowElement))))
                    {
                        return false;
                    }
                }
                if(colElement != '.')
                {
                    if(!(colHash.Add(colElement)))
                    {
                        return false;
                    }
                    if(i <= j && (!(squareCheck[colSquare].Add(colElement))))
                    {
                        return false;
                    }
                }
            }
            rowHash = new();
            colHash = new();
        }

        return true;
    }
}
