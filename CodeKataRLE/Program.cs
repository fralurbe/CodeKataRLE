using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Compresión RLE
Basándonos en el método de compresión RLE, construiremos un compresor de información. La entrada
 * será una cadena de caracteres ASCII compuesta de cualquier combinación
 * de caracteres de la 'a' a la 'z' y/o de la 'A' a la 'Z'. La salida será otra cadena de caracteres 
 * que contendrá, también, dígitos. Veamos el funcionamiento:

Cuando se encuentra un caracter en la entrada se establece en la salida el número de repeticiones 
 * contiguas y el caracter en cuestión. Por ejemplo, para una entrada "aaaa", la salida sería "4a"
 * , y para una entrada "abbbbb", la salida sería "1a5b".

Complicaremos un poco el funcionamiento descrito anteriormente añadiendo una nueva característica:
 * El número máximo de repeticiones contiguas no puede superar 5 (normalmente es un byte, esto es,
 * 256 repeticiones). Así, con la entrada "bbbbbbbaaaaaa" la salida sería "5b2b5a1a". Nótese que hay
 * 7 caracteres 'b' seguidos y hemos especificado que como máximo se pueden repetir 5, por lo que
 * quedan 5 caracteres 'b', esto es "5b" seguidos de otros dos caracteres 'b', esto es, "2b", y 
 * de forma análoga para los siguientes caracteres 'a' del ejemplo.
Ejemplos
Entrada	Salida	Explicación
""	""	Entrada vacía por lo que no hay nada que comprimir
"a"	"1a"	Un caracter 'a', "1a"
"aA"	"1a1A"	Un caracter 'a' ("1a") seguido de otro caracter 'A' ("1A")
"bbaaa"	"2b3a"	Dos caracteres 'b' ("2b") seguidos de tres caracteres 'a' ("3a")
"aaaaaabbbbbbb"	"5a1a5b2b"	Cinco caracteres 'a' ("5a"), seguidos de otro más ("1a"), seguidos de
 * cinco caracteres 'b' ("5b"), seguidos de dos más ("2b")
 */
namespace CodeKataRLE
{
    class Program
    {   
        static void Main(string[] args)
        {
            Compresor compresor = new Compresor("aaaaaaaaAAAA");
        }
    }
}
