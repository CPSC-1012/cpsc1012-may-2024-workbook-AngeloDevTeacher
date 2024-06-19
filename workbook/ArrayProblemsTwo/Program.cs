// See https://aka.ms/new-console-template for more information

/// <summary>
/// Create a lottery ticket number set given a number of values to generate and a range to generate from. There should be no duplicates in the generated numbers.
/// 
/// Name: Angelo Encarnacion
/// Last Modified: June 18th 2024
/// </summary>


// General pattern:
// 1. Display purpose
// 2. Prompt User
// 3. Generate Ticket

// Program Plan:
// Declare userInput as String
// Declare lottoNumbers as Integer[]
// Declare lottoLength as Integer
// Declare lottoRangeStart as Integer
// Declare lottoRangeEnd as Integer
// Declare randomInstance as Random
// Declare randomNumber as Integer

// Display "--Program Title--"
// Display "This program will create lotto numbers for you."

// Do 
//  Try
//      Prompt "Enter the number of lotto numbers: " lottoLength
//  Catch
//      Display "You have entered an invalid value."
//      Set lottoLength = -1
// While lottoLength < 1

// Do
//  Try
//      Prompt "Enter the starting number for the range of numbers: " lottoRangeStart
//      Prompt "Enter the ending number for the range of numbers: " lottoRangeEnd
//  Catch
//      Display "You have entered an invalid value."
// While lottoRangeEnd - lottoRangeStart >= lottoLength

// Set lottoNumbers = new lottoNumbers[lottoLength]

// For (Integer i = 0; i < lottoLength; i++)
//      Do 
//          Set randomNumber = Random.Next(lottoRangeStart, lottoRangeEnd)
//          if lottoNumbers.contains(randomNumber)
//              Set lottoNumbers[i] = randomNumber
//      While lottoNumbers[i] != 0
//

// Display lottoNumbers

