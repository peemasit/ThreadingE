using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingE {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello 4");
            //Thread.Sleep(1000);
                       
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("thread 1");
            //}).Start();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("thread 2");
            //}).Start();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("thread 3");
            //}).Start();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("thread 4");
            //}).Start();

            //var taskCompletionSource = new TaskCompletionSource<bool>();
            //var thread = new Thread(() => {
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    taskCompletionSource.TrySetResult(true);
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");

            //});
            //thread.Start();

            //Enumerable.Range(0, 100).ToList().ForEach(f => {
            //    new Thread(() => {
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //    }).Start();
            //});

            Enumerable.Range(0, 100).ToList().ForEach(f => {
                ThreadPool.QueueUserWorkItem((o) => {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
            });
            Console.ReadLine();
        }
    }
}
