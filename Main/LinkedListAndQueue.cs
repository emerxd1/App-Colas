using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Estructuras;

namespace Main
{
    public class LinkedListAndQueue
    {

        public class Queue<T>:IEnumerable<T>
        {
            private class Node
            {
                public T Value;// valor del nodo
                public Node? Next;// referencia al siguiente nodo

                public Node(T value)
                {
                    Value = value;// inicializa el valor del nodo
                }
            }

            private Node? _head; // frente: de aquí se saca
            private Node? _tail; // final: aquí se agrega

            public int Size { get; private set; }// O(1): devuelve el tamaño de la cola

            public bool IsEmpty => Size == 0 || _head is null;// O(1): devuelve true si la cola está vacía

            // Agrega un objeto al final de la cola.
            public void Enqueue(T value)
            {
                var node = new Node(value);
                if (_tail is null)
                {
                    _head = node;
                    _tail = node;
                }
                else
                {
                    _tail.Next = node;
                    _tail = node;
                }
                Size++;
            }


            // Quita y devuelve el objeto al principio de.Queue<T>
            // Devuelve default (null para tipos de referencia) si la cola está vacía.
            public T? Dequeue()
            {
                if (_head is null) return default;

                var node = _head;
                _head = node.Next;
                if (_head is null) _tail = null; // la cola quedó vacía
                Size--;
                return node.Value;
            }

            // O(1): mira el frente sin sacarlo
            public T? Peek()
            {
                return _head is null ? default : _head.Value;
            }

            //PARA PODER ITERAR SOBRE LA COLA
            public IEnumerator<T> GetEnumerator()
            {
                for (var n = _head; n is not null; n = n.Next)
                    yield return n.Value;
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        }
    }
}
