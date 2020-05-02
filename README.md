# Lab_Reposicion
Recopilación de los mejores 5 laboratorios.

Endpoints

COLECCIÓN POSTMAN: https://www.getpostman.com/collections/acf8197e5808bffe0a9e

Endpoints

Árboles multicamino: BebidaController. LABORATORIO 1

[GET]		https://localhost:44311/Bebida/

Devuelve en una lista todos los elementos Bebida que se encuentran en el árbol

[GET]		https://localhost:44311/Bebida/mango

Elemento específico dentro del árbol, “mango” es el nombre del modelo Bebida, el parámetro es el nombre de las bebidas que están en el árbol. 

[POST]	https://localhost:44326/Bebida/

Inserta una Bebida en el árbol B. Parámetros de postman: 
 
 









Compresión de Datos: CompressController, CompressionsController, DecompressController. LABORATORIO 3 y 4

[GET]		https://localhost:44311/compressions/

Endpoint para visualizar los archivos comprimidos por el sistema. 

[POST]	https://localhost:44311/compress/pruebaHuffman.huff/huffman

[POST]	https://localhost:44311/compress/test.lzw/lzw	

Envía el archivo que pasará por proceso de compresión, en este caso huffman. El formato es: /compress/nombre archivo comprimido/método

Los archivos generados se guardan en el directorio del proyecto, ejemplo en mi computadora: C:\GitHub\Lab_Reposicion\MainProject\MainProject\Compressions

[POST] 	https://localhost:44311/decompress/testDecompress.txt/huffman

[POST]	https://localhost:44311/decompress/testDecompress.txt/lzw

Métodos para descomprimir los archivos que se guardan en la carpeta Compressions del directorio del proyecto.Los archivos que serán descomprimidos los debe colocar de la carpeta generada en el proyecto
 

Cifrado de transposición. LABORATORIO 5

[POST]	https://localhost:44311/cipher/ruta/textoCifrado.txt/6x5,vertical

[POST]	https://localhost:44311/decipher/ruta/textoNormal.txt/6x5,vertical

[POST]	https://localhost:44319/cipher/caesar/textoCifrado.txt/goblin

[POST]	https://localhost:44319/decipher/caesar/textoNormal.txt/goblin

[POST]	https://localhost:44319/cipher/zigzag/textoCifrado.txt/5

[POST]	https://localhost:44319/decipher/zigzag/textoNormal.txt/5

 
 



LABORATORIO 6. DIFFIE

[POST] 	https://localhost:44311/diffie/5/6

[POST] 	https://localhost:44311/diffie/cipher/

[POST] 	https://localhost:44311/diffie/decipher/




