using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    using System;

    // Pila genérica (LIFO) implementada con un arreglo de tamaño fijo.
    // <T> permite usarla con int, char, string, etc., sin repetir código.
    public class Pila<T>
    {
        // Arreglo donde se guardan los elementos.
        private T[] datos;

        // Índice del último elemento insertado (el tope).
        // Vale -1 cuando la pila está vacía.
        private int tope;

        // Cantidad máxima de elementos que admite la pila.
        private int capacidad;

        // Constructor: recibe la capacidad que define el usuario.
        public Pila(int capacidad)
        {
            // Una pila sin espacio no tiene sentido, así que se rechaza.
            if (capacidad <= 0)
            {
                throw new ArgumentException("La capacidad debe ser mayor que 0.");
            }

            this.capacidad = capacidad;
            datos = new T[capacidad];

            // Pila vacía: todavía no hay ningún elemento.
            tope = -1;
        }

        // Propiedad de solo lectura para consultar la capacidad desde fuera.
        public int Capacidad
        {
            get
            {
                return capacidad;
            }
        }

        // Inserta un elemento en el tope.
        // Complejidad: O(1), no recorre el arreglo.
        public void Push(T x)
        {
            // Overflow: no se puede insertar si ya no hay espacio.
            if (IsFull())
            {
                throw new InvalidOperationException("OVERFLOW: la pila está llena.");
            }

            // Primero se avanza el tope y luego se guarda el dato en esa posición.
            tope = tope + 1;
            datos[tope] = x;
        }

        // Elimina y devuelve el elemento del tope.
        // Complejidad: O(1).
        public T Pop()
        {
            // Underflow: no se puede sacar de una pila vacía.
            if (IsEmpty())
            {
                throw new InvalidOperationException("UNDERFLOW: la pila está vacía.");
            }

            // Se guarda el valor antes de borrarlo para poder devolverlo.
            T x = datos[tope];

            // Se limpia la casilla y se retrocede el tope.
            datos[tope] = default(T);
            tope = tope - 1;

            return x;
        }

        // Devuelve el elemento del tope SIN eliminarlo.
        // Complejidad: O(1).
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("UNDERFLOW: la pila está vacía.");
            }

            return datos[tope];
        }

        // Indica si la pila no tiene elementos.
        // Complejidad: O(1).
        public bool IsEmpty()
        {
            if (tope == -1)
            {
                return true;
            }
            return false;
        }

        // Indica si la pila alcanzó su capacidad máxima.
        // Complejidad: O(1).
        public bool IsFull()
        {
            // El último índice válido del arreglo es capacidad - 1.
            if (tope == capacidad - 1)
            {
                return true;
            }
            return false;
        }

        // Devuelve la cantidad de elementos actuales.
        // Como el tope es un índice (empieza en 0), se le suma 1.
        // Complejidad: O(1).
        public int Size()
        {
            return tope + 1;
        }

        // Devuelve una copia de los elementos, del fondo al tope.
        // No es una operación clásica de pila: se usa para que PilaVisual pueda dibujar.
        // Complejidad: O(n), porque recorre todos los elementos.
        public T[] ToArray()
        {
            T[] copia = new T[Size()];

            for (int i = 0; i < copia.Length; i++)
            {
                copia[i] = datos[i];
            }

            return copia;
        }

        // Devuelve un texto con el contenido, por ejemplo: [10, 20, 30] ← tope
        // Complejidad: O(n).
        public string Mostrar()
        {
            string texto = "[";
            T[] elementos = ToArray();

            for (int i = 0; i < elementos.Length; i++)
            {
                texto = texto + elementos[i];

                // Se agrega la coma solo si no es el último elemento.
                if (i < elementos.Length - 1)
                {
                    texto = texto + ", ";
                }
            }

            texto = texto + "] ← tope";
            return texto;
        }
    }
}
