# Reto Técnico: Procesamiento de Transacciones Bancarias (CLI)


## Introducción:
El presente reto forma parte del proceso de selección para el programa de Software Engineer de Interbank, Perú.


## Instrucciones de Ejecución:
Este proyecto requiere de la librería CsvHelper para ejecutarse. Para instalarlo, sólo es necesario abrir la solución (archivo .sln) 
con Visual Studio 2019 o superior. Automáticamente se instalará y ejecutará.


## Enfoque y Solución:
- Para solucionar este reto, primero me aseguré de crear una clase con los mismos atributos que la fuente de datos (archivo CSV), para así poder trabajar 
de manera adecuada. 
- Como segundo paso, fue ubicar correctamente el archivo que se va a leer. Con la finalidad de ser ubicado facilmente, ubiqué el archivo dentro del proyecto
único que forma parte de esta solución.
- Como tercer paso, elegí la mejor forma de leer un archivo CSV, y la librería CsvHelper es la mejor opción para este caso.
- Como cuarto paso, procedí con el algoritmo, inicialmente si no encuentra el archivo CSV, muestra el mensaje y la ruta que se pretende leer, 
caso contrario, procesa los datos recorriendo uno por uno los registros, haciendo los cálculos respectivos utilizando variables
acumuladoras y contadoras.
- Tras recorrer todos los registros, se imprimen las variables en el reporte.


## Estructura del Proyecto:
 - Como toda solución de .Net, ésta se compone de proyectos, para el caso un sólo proyecto (carpeta TransaccionesBancarias), el cual se centra en el archivo **program.cs**
que contiene el algoritmo que procesará las transacciones del archivo CSV.
 - Se ha creado la clase **Transaccion** en el archivo Transaccion.cs, con la finalidad de usar sus atributos para mapear los campos del 
archivo CSV.
 - Dentro de la carpeta **TransaccionesBancarias** del proyecto que forma parte de la solución se encuentra también el archivo CSV que será procesado.
 - Los demás archivos son generados automáticamente por el IDE VS 2019.


## Autor

👤 **Sergio Zambrano**

- Github: [@sergiomauz](https://github.com/sergiomauz)
- Twitter: [@sergiomauz](https://twitter.com/sergiomauz)
- Linkedin: [Sergio Zambrano](https://www.linkedin.com/in/sergiomauz/)


## 🤝 Contribuciones
Para contribuciones y correcciones, siéntete libre de abrir un hilo en [issues page](../../issues/).


## Muéstrame tu apoyo
Deja una ⭐️ si te gusta el proyecto!


## 📝 Licencia
Este proyecto está bajo licencia [MIT](./LICENSE).