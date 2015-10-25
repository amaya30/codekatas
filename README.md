# Code Katas #

"Code Kata" is a term coined by Dave Thomas, co-author of the book The Pragmatic Programmer.  It's an exercise to help a programmer perfect their skills and improve efficiencies with the tools used to program. 

#### References ####

[http://www.codekatas.org/]()

## Fizz Buzz ##

**URL:** [http://codingkata.net/Katas/Beginner/FizzBuzz]()

### Description ###

It’s the summer of 1923. You and a few friends are on holiday in Goeteborg, Sweden. After one round of starköl in the Nobel Bar you start to feel funny. So you make fun of people around you – loudly. As you spot someone who has that distinct Einstein-haircut you tell him that "only two things are infinite, the universe and your stupidity, and I’m not sure about the former".

As it turns out this man is indeed Einstein celebrating after his nobel price acceptance speech – and now he is mad at you. To settle this issue like civilized gentlemen he proposes a little drinking game called "fizz-buzz". In order to leave the table without a serious alcohol poisoning but some of your pride left you decide to do what every person would do: Cheat!

### Rules ###

Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz. Numbers divisible by both become fizzbuzz. A player who makes a mistake has to take a drink. 
Einstein will choose a random number to start with – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz…


## String Calculator ##

**URL:** [http://osherove.com/tdd-kata-1/]()

1. Create a simple String calculator with a method int Add(string numbers)
	1. The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
	2. Start with the simplest test case of an empty string and move to 1 and two numbers
	3. Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
	4. Remember to refactor after each passing test
2. Allow the Add method to handle an unknown amount of numbers
3. Allow the Add method to handle new lines between numbers (instead of commas).
	1. the following input is ok:  “1\n2,3”  (will equal 6)
	2. the following input is NOT ok:  “1,\n” (not need to prove it - just clarifying)
4. Support different delimiters
	1. to change a delimiter, the beginning of the string will contain a separate line that looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
	2. the first line is optional. all existing scenarios should still be supported
5. Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.if there are multiple negatives, show all of them in the exception message
6. Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2
7. Delimiters can be of any length with the following format:  “//[delimiter]\n” for example: “//[***]\n1***2***3” should return 6
8. Allow multiple delimiters like this:  “//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6.
9. make sure you can also handle multiple delimiters with length longer than one char

## Tea Party ##

### Description ###

You are dead – but that doesn’t mean you can’t throw a social event. In heaven you are famous for your extraordinary tea parties. This time the guest list is quite astonishing – 8 famous British people announced their visit. So don’t mess up!

Your task is to welcome your guests properly: Some are female and some were knighted by the queen.
So greet them correctly – or this will be your last hosting.

**For example:**

- Jane Austen is a women, so say Hello Ms. Austen
- George Orwell is a man, so say Hello Mr. Orwell
- Isaac Newton was knighted, so say Hello Sir Newton
