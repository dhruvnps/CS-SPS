using System;

class BinarySearchTree
{
    public class Node
    {
        public int item;
        public Node left;
        public Node right;

        public Node(int item)
        {
            this.item = item;
        }
    }

    Node root;

    public void Insert(int item)
    {
        root = Insert(root, item);
    }

    private Node Insert(Node node, int item)
    {
        if (node == null)
        {
            return new Node(item);
        }
        else if (item < node.item)
        {
            node.left = Insert(node.left, item);
        }
        else if (item > node.item)
        {
            node.right = Insert(node.right, item);
        }
        return node;
    }

    public void Remove(int item)
    {
        Remove(root, item);
    }

    private void Remove(Node node, int item)
    {
        if (item == node.left.item)
        {
            node.left = null;
        }
        else if (item == node.right.item)
        {
            node.right = null;
        }
        else if (item < node.item)
        {
            Remove(node.left, item);
        }
        else if (item > node.item)
        {
            Remove(node.right, item);
        }
    }

    public bool Contains(int item)
    {
        return Contains(root, item);
    }

    private bool Contains(Node node, int item)
    {
        if (node == null)
        {
            return false;
        }
        if (node.item == item)
        {
            return true;
        }
        return Contains(node.left, item) || Contains(node.right, item);
    }

    public void Inorder()
    {
        Console.WriteLine("\nInorder:");
        Inorder(root);
    }

    private void Inorder(Node node)
    {
        if (node != null)
        {
            Inorder(node.left);
            Console.WriteLine(node.item);
            Inorder(node.right);
        }
    }

    public void Postorder()
    {
        Console.WriteLine("\nPostorder:");
        Postorder(root);
    }

    private void Postorder(Node node)
    {
        if (node != null)
        {
            Inorder(node.left);
            Inorder(node.right);
            Console.WriteLine(node.item);
        }
    }

    public void BreadthFirst()
    {
        Console.WriteLine("\nBreadth First:");

        // using my dynamic queue implementaion
        Queue<Node> queue = new Queue<Node>();
        queue.Append(root);

        Node node;
        while (!queue.IsEmpty())
        {
            node = queue.Remove();
            if (node != null)
            {
                queue.Append(node.left);
                queue.Append(node.right);
                Console.WriteLine(node.item);
            }
        }
    }
}