using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binary_Search_Tree;

namespace Binary_Search_Tree
{
    class BSTree
    {
        private Node _root = null;

        public void Insert(int value)
        {

            if (_root == null)
            {
                _root = new Node();
                _root.Value = value;
            }
            else
            {
                Node currentNode = _root;
                // Opakovat
                while(true)
                {
                    // Pokud je větší než tenhle Node
                    if (value > currentNode.Value)
                    {
                        //Pokud je pravá větev volná
                        if (currentNode.RightChild == null)
                        {
                            currentNode.RightChild = new Node();
                            currentNode.RightChild.Value = value;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightChild;
                        }
                    }
                    // Pokud je menší než tenhle Node
                    else
                    {
                        //Pokud je levá větev volná
                        if (currentNode.LeftChild == null)
                        {
                            currentNode.LeftChild = new Node();
                            currentNode.LeftChild.Value = value;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftChild;
                        }
                    }

                }
            }

        }

        public void Delete(int value)
        {

        }

        public int SubtreeMin(Node startNode)
        {
            return 0;
        }

        public bool Search(int value)
        {
            if (_root == null)
            {
                return false;
            }
            else
            {
                Node currentNode = _root;
                // Opakovat
                while (true)
                {
                    // Pokud je větší než tenhle Node, hledá napravo.
                    if (value > currentNode.Value)
                    {
                        // Pokud v pravé větvi nic není
                        if (currentNode.RightChild == null)
                        {
                            return false;
                        }
                        else
                        {
                            // Pokud je tam to číslo co hledáme
                            if (currentNode.RightChild.Value == value)
                            {
                                return true;
                                break;
                            }
                            else
                            {
                                currentNode = currentNode.RightChild;
                            }
                        }
                    }
                    // Pokud je menší než tenhle Node
                    else
                    {
                        // Pokud v levé větvi nic není
                        if (currentNode.LeftChild == null)
                        {
                            return false;
                        }
                        else
                        {
                            // Pokud je tam to číslo co hledáme
                            if (currentNode.LeftChild.Value == value)
                            {
                                return true;
                                break;
                            }
                            else
                            {
                                currentNode = currentNode.LeftChild;
                            }
                        }
                    }

                }
            }
        }

        public Node GetRoot()
        {
            return _root;
        }
    }
}
