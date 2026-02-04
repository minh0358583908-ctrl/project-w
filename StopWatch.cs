using System;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public DateTime StartTime
    {
        get { return startTime; }
    }
    public DateTime EndTime
    {
        get { return endTime; }
    }
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }
    public double GetElapsedTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }
}

public class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main(string[] args)
    {
        int size = 100000;
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(0, 100000);
        }
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        SelectionSort(numbers);
        stopWatch.Stop();
        Console.WriteLine("Thời gian chạy Selection Sort (ms): "
                          + stopWatch.GetElapsedTime());
    }
}
