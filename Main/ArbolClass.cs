using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class ArbolClass
    {

        public class Node
        {
            public int Dato;//
            public Node left, right;
            public Node(int dato)
            {
                Dato = dato;
              
            }
            public class ArbolBinario 
            {
                public Node Raiz;
                public Node Insertar(Node n, int d) 
                {
                    if (n == null) return new Node(d);
                    if (d < n.Dato) n.left = Insertar(n.left, d);
                    else if(d>n.Dato) n.right = Insertar(n.right, d);
                    return n;
                }

                public bool Buscar(Node n, int d)
                {
                    if (n == null) return false;
                    if (d==n.Dato) return true;
                    if (d < n.Dato)
                    {
                        return Buscar(n.left, d);
                    }
                    else
                    {
                        return Buscar(n.right, d);
                    }

                }

                public Node Eliminar(Node n, int d)
                {
                    if (n == null) return null;
                    if (d < n.Dato) n.left = Eliminar(n.left, d);
                    else if (d > n.Dato) n.right = Eliminar(n.right, d);
                    else 
                    {
                        if (n.left == null) return n.left;
                        if (n.right == null) return n.right;
                        Node s = n.right;
                        while (s.left != null) s = s.left;
                        n.Dato=s.Dato;
                        n.right = Eliminar(n.right, s.Dato);
                    }
                    return n;
                }
                public string InOrden(Node n)
                {
                    if (n == null) return "";
                    return InOrden(n.left) + n.Dato + " " + InOrden(n.right);
                }

                public string PreOrden(Node n)
                {
                    if (n == null) return "";
                    return n.Dato + " " + PreOrden(n.left) + PreOrden(n.right);
                }

                public string PostOrden(Node n)
                {
                    if (n == null) return "";
                    return PostOrden(n.left) + PostOrden(n.right) + n.Dato + " ";
                }

                public int Altura(Node n)
                {
                    if (n == null) return -1;
                    return 1+ Math.Max(Altura(n.left), Altura(n.right));
                }

                public int ContarNodos(Node n) 
                {
                    if (n == null) return 0;
                    return 1 + ContarNodos(n.left) + ContarNodos(n.right);
                }
                

            }
        }
    }
}
