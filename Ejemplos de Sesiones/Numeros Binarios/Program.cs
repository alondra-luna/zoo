
 
class GFG {
    static int binarySearch(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;
        while (l <= r) {
            int m = l + (r - l) / 2;
 
            if (arr[m] == x)
                return m;
 
            if (arr[m] < x)
                l = m + 1;
 
            else
                r = m - 1;
        }
 
        return -1;
    }
 
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 5, 6, 6, 1, 1, 1,  10, 40, };
        int n = arr.Length;
        int x = 10;
        int result = binarySearch(arr, x);
        if (result == -1)
            Console.WriteLine("Elemento no presente");
        else
            Console.WriteLine("Elemento encontrado en "+ "binario" + result);
    }
}