using System;

namespace SingletonDesignPattern
{
    /*
     * Possible Questions
     * How do you cope with thread safety when creating a Singleton?
       What is the difference between lazy and eager instantiation? Why does it matter?
       Are singletons a good pattern to use?
       How do singletons affect testing?
       -    Singletons are not a good coding practice as they cause
            high coupling and violate dependency injection principles.  
            This makes code really hard to test.  
            Any object making use of a singleton needs to use a static method to get access to it.  This means it is not being “injected” in and so cannot be stubbed out for use in testing. 

    */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object instanceLock = new object();
        public static Singleton GetInstance
        {
            get
            {
                #region not to thread-safe.It means in a multithreaded environment, it will able to create multiple instances of the singleton class. 
                if (instance == null)
                {
                    instance = new Singleton();
                }
                //return instance;dregion
                #endregion


                #region Thread-safe Singleton Design Pattern . slow down your application as only one thread can access the GetInstance property at any given point of time

                //lock (instanceLock)
                //{
                //    if (instance == null)
                //    {
                //        instance = new Singleton();
                //    }
                //    return instance;
                //}
                #endregion

                #region Double checked locking approach for Thread-safe Singleton
                //if (instance == null)
                //{
                //    lock (instanceLock)
                //    {
                //        if (instance == null)
                //        {
                //            instance = new Singleton();
                //        }
                //    }
                //}
                return instance;
                #endregion
            }
        }
        private Singleton()// ensure that object is created
        {
            counter++;
            Console.WriteLine("Counter value " + counter);
        }

        public void printdeatails(string message)
        {
            Console.WriteLine(message);
        }

        #region this is why we need sealed to class for nested class can inherites
        //public class Derivedsingalton : Singleton 
        //{


        //}
        #endregion


    }

    #region Eager Loading using the Singleton design pattern with one example.  
    /**/

    //public sealed class Singleton
    //{
    //    private static readonly Singleton singleInstance = new Singleton();
    //    private static int counter = 0;
    //    private Singleton()
    //    {
    //        counter++;
    //        Console.WriteLine("Counter Value " + counter.ToString());
    //    }

    //    public static Singleton GetInstance
    //    {
    //        get
    //        {
    //            return singleInstance;
    //        }
    //    }
    //    public void printdeatails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
    #endregion

}
/*
 * To restrict the multiple instance creation then use the Privete Contructor
 * Sealed class used for resctrict of inheritance
 * 
 */
