// Generating array's structure
void fillArray (int[] collection) {
    int lenght = collection.Length;
    int index = 0;
    while ( index < lenght ) {
        collection [ index ] = new Random().Next( 1, 10 );
        index++;
    }
}

// Printing array's structure
void printArray (int[] collect) {
    int count = collect.Length;
    int position = 0;
    while ( position < count ) {
        Console.WriteLine(collect[position]);
        position++;
    }
}

// Searching for condition
int indexOf (int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while ( index < count ) {
        if ( collection [index] == find ) {
            position = index;
            break;
        }   
        index++;
    }
    return position;
}

int [] array = new int[10];

fillArray(array);

// Put 4 on the Array's index 4 and 9 number 4
array[4] = 4;
array[9] = 4;

printArray(array);
Console.WriteLine();

int pos = indexOf (array, 4);

switch (pos) {
    case -1:
        Console.WriteLine("Sorry!");
        break;
    default:
        Console.WriteLine(pos);
        break;
}