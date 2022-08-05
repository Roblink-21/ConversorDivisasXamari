# ConversorDivisasXamari

# Integrantes:
  - Roberth Pincha
  - Luis Jacome
  
# Detalle

Esta aplicación desarrollada en Xamarin.Forms nos permite realizar la conversión de 5 monedas diferentes:
  - Euro
  - Dolar
  - Libra esterlina
  - Peso colombiano
  - Peso chileno
 
  ![image](https://user-images.githubusercontent.com/58127103/182954174-760aa0f1-6b18-41fa-8644-e9adb0efe1a7.png)

Debemos ingresar la cantidad, seleccionar el tipo de moneda que se está ingresando y selecionar al tipo de moneda que se desea realizar la conversión.

# MainPage

Dentro de los archivos de configuracion de la aplicacion, el mainPage utiliza un boton para navegar en otra vista lo cual se lo realiza a traves de una funcion llamada "Navigation.PushAsync(new Convertir());" la cual tiene como parametro la utilizacion de la siguiente vista donde se encuentra las funciones del conversor de divisas.

![image](https://user-images.githubusercontent.com/58041699/182980284-7d5ae5ec-df62-4fce-a239-f261fa76f3d5.png)

Monedas disponibles para la conversión

Dentro de la aplicacion se puede hacer uso de un Select o tambien conocido como Picker el cual puede almacenar algunas opciones de las cuales podemos indicar el tipo de funcion a realizar en este caso el picker almacenara los tipos de moneda y por ende usaremos la seleccion que esta representada a traves de un index la cual nos ayudara a identificar y usar el tipo de funcion a utilizar. 

![image](https://user-images.githubusercontent.com/58041699/182980671-5c62a6f0-5aea-4845-8dbd-877a60a5a750.png)


![image](https://user-images.githubusercontent.com/58041699/182980373-7cf58395-d866-4e95-9390-96f3e04cb4ee.png)

- Conversión de Dolar a Euro

Para realizar la logica de conversion se hace uso del select que a traves de un index obtendremos su seleccion, y junto a condicionales podemos buscar la funcion de conversion la cual esta dada por tomar el valor de entrada y transformarlo a un tipo numerico para luego realizar las operaciones de conversion y despues mostrar el resultado en la salida.

![image](https://user-images.githubusercontent.com/58041699/182980412-d0de87d4-7573-4e87-acd6-7adccca9deef.png)

# Funcionamiento en celular modelo Samsung Galaxy J6

![1](https://user-images.githubusercontent.com/58127103/182977612-d90d52e2-3c87-42dd-972e-7d0cce21b26e.png)

![2](https://user-images.githubusercontent.com/58127103/182977622-37ddb5ab-7211-4be9-811e-2682f142fd68.png)

![3](https://user-images.githubusercontent.com/58127103/182977632-6a05c2c0-80fa-4d61-b9bf-a50b5eac994e.png)




