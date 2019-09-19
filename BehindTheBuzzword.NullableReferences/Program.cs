using System;

namespace BehindTheBuzzword.NullableReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable reference type
            // =======================
            Console.WriteLine($"The following is intended to be a nullable reference type:");
            NullableType? nullableTypeExample = null;

            // now use it
            if (nullableTypeExample.Count > 1)
            {
                // do something
            }


            // Non-nullable reference types
            // ===========================
            Console.WriteLine($"The following is intended to be a non nullable reference type:");
            NonNullableType nonNullableTypeExample = null;

            // now use it
            if (nonNullableTypeExample.Count > 1)
            {
                // do something
            }

            Console.WriteLine($"The following is intended to be a non nullable reference type that's not initialised:");
            NonNullableType nonNullableTypeExampleNonInitialised;

            Console.WriteLine($"Set the non nullable type to null now:");
            nonNullableTypeExampleNonInitialised = null;
            // now use it
            if (nonNullableTypeExample.Count > 1)
            {
                // do something
            }
        }
    }
}
