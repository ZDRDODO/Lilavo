using System;

public class Queue
{
	private static int front, rear, capacity;
	private static int[] queue;

	public Queue(int c)
	{
		front = rear = 0;
		capacity = c;
		queue = new int[capacity];
	}
	public void queueEnqueue(int data)
	{
		if (capacity == rear)
		{
			Console.Write("\nQueue is full\n");
			return;
		}
		else
		{
			queue[rear] = data;
			rear++;
		}
		return;
	}
	public void queueDequeue()
	{
		if (front == rear)
		{
			Console.Write("\nQueue is empty\n");
			return;
		}
		else
		{
			for (int i = 0; i < rear - 1; i++)
			{
				queue[i] = queue[i + 1];
			} 
			if (rear < capacity)
				queue[rear] = 0;
			rear--;
		}
		return;
	}
	public void queueDisplay()
	{
		int i;
		if (front == rear)
		{
			Console.Write("\nQueue is Empty\n");
			return;
		}
		for (i = front; i < rear; i++)
		{
			Console.Write(" {0} <-- ", queue[i]);
		}
		return;
	}
	public void queueFront()
	{
		if (front == rear)
		{
			Console.Write("\nQueue is Empty\n");
			return;
		}
		Console.Write("\nFront Element is: {0}", queue[front]);
		return;
	}
}

public class StaticQueueinCsharp
{
	public static void Main(String[] args)
	{
		Queue q = new Queue(4);
		q.queueDisplay();
		q.queueEnqueue(20);
		q.queueEnqueue(30);
		q.queueEnqueue(40);
		q.queueEnqueue(50);
		q.queueDisplay(); 
		q.queueEnqueue(60);
		q.queueDisplay();
		q.queueDequeue();
		q.queueDequeue();
		Console.Write("\n\nafter two node deletion\n\n");
		q.queueDisplay();
		q.queueFront();
	}
} 
