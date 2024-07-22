public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // If the value already exists, do nothing
        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // If the searched value is equal to the value of the current node
        if (value == Data)
        {
            return true;
        }
        else if (value < Data) // If the searched value is less than the value of the current node
        {
            if (Left == null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else // If the searched value is greater than the value of the current node
        {
            if (Right == null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
        // return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = 0;
        int rightHeight = 0;

        // Calculate the height of the left subtree
        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }

        // Calculate the height of the right subtree
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }

        // The height of the current node is 1 plus the greater height of its subtrees
        if (leftHeight > rightHeight)
        {
            return 1 + leftHeight;
        }
        else
        {
            return 1 + rightHeight;
        }

        //return 0; // Replace this line with the correct return statement(s)
    }
}