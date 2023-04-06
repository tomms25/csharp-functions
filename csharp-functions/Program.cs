// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina

int[] nums = { 2, 6, 7, 5, 3, 9 };

void StampaArray(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ",";
        }
    }
    result += "]";

    Console.WriteLine(result);
}




//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    var result = numero * numero;
    return result;
}


//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] result = (int[])array.Clone();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Quadrato(array[i]);
    }

    return result;
}

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}



int[] nums = { 2, 6, 7, 5, 3, 9 };

