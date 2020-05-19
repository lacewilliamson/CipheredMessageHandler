# CipheredMessageHandler Program Concept
A program that accepts a block of text as the _one-time pad_ text and uses it against the user supplied _plaintext_ to create ciphertext. The process can be reversed to decrypt the ciphertext and convert it back into plaintext, if the original _one-time pad_ text is known.




## Features
---
Accepts user input (plaintext/ciphertext and one-time pad text, currently via the command line) and converts it to or from ciphertext using a tabula recta / algorithm.


## Background 
---
A few years ago my elder brother introduced me to shortwave radio listening (SWL). As I revelled in this previously unknown no man's land of the electromagnetic spectrum, I came across something the SWL world affectionately refers to as "Number Stations". 

Commonly believed (with supporting evidence) to be clandestine intelligence agencies from various countries communicating with their agents around the world, these spurious broadcasts are typically blocks of numbers read by a monotonous and often mechanized voice:

	1...4...3...6...5...
	5...9...6...4...3...
	2...3...1...5...5...

Research from there led me to countless Wikipedia articles about enciphered communications, unbreakable codes, and generally interesting articles on encryption and decryption. I didn't claim to understand all of it, and still don't. But I was intrigued by the idea that agents are still today actively spying and communicating with secret messages using publicly accessible (if unintelligible) radio transmissions. 

So I started fiddling. The first version of this software I called DENcipher, which was written around 2014. I used a two dimensional array of alphanumeric characters as a lookup table to create a digital equivalent of the [Vigenère square](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher). The small console program was written in python, and used Blender as the IDE. (Yes, [that Blender](https://www.blender.org/), because it was what I knew how to use and I wanted to see if it could be done.)

The "second" version was technically an attempted port from Python which turned into a fully rewritten version for the Commodore 64, in Basic. (Any excuse to justify a retrocomputing hobby is a good excuse.) In this version the enciphering and deciphering was purely mathematical, as I realized lookup tables weren't necessary, though they had been a good learning experience.


Which brings us to more-or-less present day. This has been a little side project that keeps calling to me every few years, and since I'm now diving in to C#, it seems like now would is a great time to revisit the subject and flesh it out even further.

## Usage
---
Current usage is to run at the command line. It asks for a single plaintext character and a one-time pad character. Supplying them will return the enciphered character.

## To-do
---


- Create a method that utilizes the new character converting methods to parse entire strings.

- Add error handling for methods, either allowing for lower case and upper case individual handling, or converting all inputs to only upper case alpha characters.

- Create the base method (mathematically), for converting a single enciphered character to a plaintext character given a one-time pad character.

- **DONE** - ~~Create the base method, (mathematically), for converting a single plaintext character to an enciphered character given a one-time pad character.~~
- 


## Roadmap / Wishlist
---
 - Create ability to output clean completed text files in Markdown.
 - Create a character frequency analysis function 




