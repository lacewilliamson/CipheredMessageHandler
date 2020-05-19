# CipheredMessageHandler Program Concept
A program that accepts a block of text as the _one-time pad_ text and uses it against the user supplied _plaintext_ to create ciphertext. The process can be reversed to decrypt the ciphertext and convert it back into plaintext, if the original _one-time pad_ text is known.




## Features
---
Accepts user input (plaintext/ciphertext and One-Time pad text, currently via the command line) and converts it to or from ciphertext using a tabula recta algorithm.


## Background 
---
A few years ago my elder brother introduced me to shortwave radio listening (SWL). As I revelled in this previously unknown  no man's land of the electromagnetic spectrum, I came across something the SWL world affectionately refers to as "Number Stations". 

Commonly believed to be clandestine intelligence agencies from various countries communicating with their agents around the world, these spurious broadcasts are typically blocks of numbers read by a monotonous (typically computerized) voice:

	1...4...3...6...5...
	5...9...6...4...3...
	2...3...1...5...5...

Research from there lead me to countless Wikipedia articles about enciphered communications, unbreakable codes (yes, mathematically they DO exist!) and generally interesting articles on encryption and decryption. I didn't claim to understand all of it, and still don't. But I was intrigued by the idea that agents are still today actively spying and communicating with secret messages using publically accessable (if unintelligable) radio transmissions. 

So I started fiddling. The first version of this software I called DENcipher, which was written around 2014. I used a two dimensional array of alphanumeric characters as a lookup table to create a digital equivilant of the [Vigenère square](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher). The small console program was written in python, and used Blender as the IDE. (Yes, [that Blender](https://www.blender.org/), because it was what I knew how to use and I wanted to see if it could be done.)

The "second" version was technically an attempted port from Python which turned into a fully rewritten version for the Commodore 64, in Basic. (Any excuse to justify a retrocomputing hobby is a good excuse.) In this version the enciphering and deciphering was purely mathematical, as I realized lookup tables weren't neccessary, though they had been a good learning experience.


Which brings us to more-or-less present day.

## Usage
---

## To-do
---
- Create the base method, (mathematically), for converting a single plaintext character to an enciphered character given a one-time pad character.
- 


## Roadmap
---
 - Create a character frequency analysis function 




