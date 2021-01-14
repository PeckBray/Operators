'Brayden Peck
'RCET 0265
'Spring 2021
'Operators Example
'https://github.com/PeckBray/Operators.git


Option Compare Text                              'Switch compare method

Module Operators

    Sub Main()
        Console.WriteLine(2 + 2)                'Add
        Console.WriteLine(8 - 2)                'Subtract
        Console.WriteLine(5 * 5)                'Multiply
        Console.WriteLine(1 / 2)                'Regular Div
        Console.WriteLine(1 \ 2)                'Integer Div
        Console.WriteLine(1 Mod 2)              'Division returns only the remainder
        Console.WriteLine(5 ^ 5)                'Exponential

        Console.WriteLine("Hello" + " world")   'Concatinate strings
        Console.WriteLine("Hello" + "5")

        'Comparisons
        Console.WriteLine(3 > 4)                'Greater than
        Console.WriteLine(3 < 4)                'Less than
        Console.WriteLine(3 = 4)                'Equal to
        Console.WriteLine(3 <> 4)               'Not equal
        Console.WriteLine(3 >= 4)               'Greater than or equal
        Console.WriteLine(3 <= 4)               'Less than or equal

        Console.WriteLine("a" > "A")            'Compare letters in strings
        Console.WriteLine("AAA" < "ABA")        'Compare letters in strings with multiple letters
        Console.WriteLine("a" > "ABC")          'Compare strings with different ammounts of letters

        Console.ReadLine()

    End Sub

End Module
