// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 1 -----------------------");
string numeros = "";
for(int i = 0; i < 100;i++){
    if(i+1 < 100){
        numeros += $"{i+1},";
    }else{
        numeros += $"{i+1}.";
    }
}
Console.WriteLine(numeros);

// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números pares desde 1 hasta ese número usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 2 -----------------------\n");
string n1;
bool flag = true;
numeros = "";
while(flag){
    Console.Write("Ingrese un numero entero positivo: ");
    n1 = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(n1)){
        Console.WriteLine("Ingrese una opcion valida");
    }else if(Convert.ToDouble(n1) % 1 != 0){
        Console.WriteLine("Ingrese una opcion valida");
    }else if(Convert.ToInt32(n1) == 0 || Convert.ToInt32(n1) < 0){
        Console.WriteLine("Ingrese una opcion valida");
    }else{
        flag = false;
    }
    
    for(int i = 0; i < Convert.ToInt32(n1);i++){
    if(i+1 == 1){
        numeros += $"{i+1},";
    }else if((i+1) % 2 == 0){
        numeros += $"{i+1},";
        }
    }
    Console.WriteLine(numeros);
}

// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 3 -----------------------\n");
flag = true;
numeros = "";
while(flag){
    Console.Write("Ingrese un numero entero positivo: ");
    n1 = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(n1)){
        Console.WriteLine("Ingrese una opcion valida");
    }else if(Convert.ToDouble(n1) % 1 != 0){
        Console.WriteLine("Ingrese una opcion valida");
    }else if(Convert.ToInt32(n1) == 0 || Convert.ToInt32(n1) < 0){
        Console.WriteLine("Ingrese una opcion valida");
    }else{
        flag = false;
    }
    for (int i = 0; i < 10;i++){
        Console.WriteLine($"{n1} * {i+1} = {(i+1) * Convert.ToInt32(n1)}");
    }
}

// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado alto, 
// demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que adivine correctamente usando un ciclo do-while.
Console.WriteLine("\n---------------------Ejercicio 4 -----------------------\n");

// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números impares desde ese número hasta 1 usando un ciclo while.
Console.WriteLine("\n---------------------Ejercicio 5 -----------------------\n");
// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no es "secreta", sigue pidiendo al usuario que ingrese la 
// contraseña hasta que sea correcta usando un ciclo while.
Console.WriteLine("\n---------------------Ejercicio 6 -----------------------\n");
// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la secuencia de Fibonacci hasta ese número usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 7 -----------------------\n");
string nf, concatenacion = "";
int suma = 0, numero1 = 0, numero2 = 0;
Console.WriteLine("Ingrese un numero");
nf = Console.ReadLine();
for (int i = 0; i < Convert.ToInt32(nf); i++){
    if (suma == 0){
        suma = 1;
        numero1 = 1;
        concatenacion += "0,1,1";
    }else if(suma == 1){
        suma += numero1;
        concatenacion += $",{suma}";
    }else{
        if(suma == 2){
            numero2 = suma;
            suma += numero1;
            concatenacion += $",{suma}";
        }else{
            if(numero2 > numero1){
                numero1 = suma;
                suma += numero2;
                concatenacion += $",{suma}";
            }else{
                numero2 = suma;
                suma += numero1;
                concatenacion += $",{suma}";
            }
        }
    }
}
Console.WriteLine(concatenacion);
// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el número es primo o no usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 8 -----------------------\n");
// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la palabra en una línea separada usando un ciclo foreach.
Console.WriteLine("\n---------------------Ejercicio 9 -----------------------\n");
// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma de todos los números desde 1 hasta ese número usando un ciclo for.
Console.WriteLine("\n---------------------Ejercicio 10 -----------------------\n");