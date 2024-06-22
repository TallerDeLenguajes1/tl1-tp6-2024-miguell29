# Taller de Lenguajes 1 - TP6 - Miguel Juárez
##### ¿String es una tipo por valor o un tipo por referencia?

- Un string es un tipo por referencia.

##### ¿Qué secuencias de escape tiene el tipo string?

|Secuencia de escape |	Nombre de carácter |	Codificación Unicode|
|--------------------|---------------------|------------------------|
|\' |	Comilla simple |	0x0027|
|\" 	|Comilla doble |	0x0022|
|\ 	| Barra diagonal inversa| 	0x005C
|\0 |	Null 	|0x0000|
|\a 	|Alerta 	|0x0007|
|\b 	|Retroceso |	0x0008|
|\f 	|Avance de página| 	0x000C|
|\n 	|Nueva línea |	0x000A|
|\r 	|Retorno de carro |	0x000D|
|\t 	|Tabulación horizontal |	0x0009|
|\v 	|Tabulación vertical |	0x000B|
|\u 	|Secuencia de escape Unicode (UTF-16) |	\uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")|
|\U 	|Secuencia de escape Unicode (UTF-32) |	\U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")|
|\x 	|Secuencia de escape Unicode similar a "\u" excepto con longitud variable |	\xH[H][H][H] (intervalo: 0 - FFFF ejemplo: \x00E7 o \x0E7 o \xE7 = "ç")|

##### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

- Los caracteres @ y $ se utilizan como prefijos antes de las cadenas de texto para proporcionar funcionalidades adicionales. A continuación, se explica el propósito y el uso de cada uno de estos caracteres:

###### @ - Cadena literal (Verbatim String)

- El prefijo @ se utiliza para crear cadenas literales, donde las secuencias de escape no se procesan y los caracteres especiales se interpretan como texto literal. Además, permite que las cadenas de texto se extiendan en múltiples líneas sin necesidad de concatenación explícita.

###### $ - Interpolación de cadenas (String Interpolation)

- El prefijo $ se utiliza para crear cadenas interpoladas, donde se pueden incluir expresiones dentro de llaves {} que serán evaluadas y sus resultados insertados en la cadena.

######W Combinación de @ y $ (Literal y Interpolada)

- Es posible combinar ambos prefijos @$ o $@ para crear una cadena que sea tanto literal como interpolada. Esto permite que las expresiones dentro de {} sean evaluadas mientras que las secuencias de escape se interpretan literalmente.
