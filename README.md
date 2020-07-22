# DecoderEncoder
 Application used to encode and decode messages using various types of ciphers. 
 Currently implemented ciphers:
 * Caesar Shift
 * Vigenere Cipher
## Getting Started
To get started, download the 'setup.exe' file from DecoderEncoderSetup/Debug.
### Installing
Launching the 'setup.exe' file from above launch the Setup Wizard which will install the program.
## Ciphers
* Caesar Shift
    * The Caesar Shift (or Caesar Cipher) is a simple substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet. The following picture represents a Caesar Shift with a shift value of 3.
    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4a/Caesar_cipher_left_shift_of_3.svg" width=200px hight=200px/>

* Vigenere Cipher
    * The Vigenere Cipher is a method of encrypting alphabetic text by using a series of interwoven Caesar Shifts, based on the letters of a keyword. 
    * To encrypt, a table of alphabets can be used, a Vigenere square. It has the alphabet written out 26 times in different rows, each alphabet shifted cyclically to the left compared to the previous alphabet. 

    <img src="https://upload.wikimedia.org/wikipedia/commons/9/9a/Vigen%C3%A8re_square_shading.svg" width=300px hight=300px/>
    * For example, suppose that the plaintext to be encrypted is:
    > ATTACKATDAWN
    The person sending the message chooses a keyword and repeats it until it matches the length of the plaintext, for example, the keyword "LEMON":
    > LEMONLEMONLE
    * Each row starts with a key letter. The rest of the row holds the letters A to Z (in shifted order). Although there are 26 key rows shown, a code will use only as many keys (different alphabets) as there are unique letters in the key string, here just 5 keys: (L, E, M, O, N).
    * For example, the first letter of the plaintext, A, is paired with L, the first letter of the key. Therefore, row L and column A of the Vigenere square are used, namely L. Similarly, for the second letter of the plaintext, the second letter of the key is used. The letter at row E and column T is X. The rest of the plaintext is enciphered in a similar fashion:
    > Plaintext: ATTACKATDAWN
    > Key: LEMONLEMONLE
    > Ciphertext: LXFOPVEFRNHR

## Using the Ciphers
* Caesar Shift
    * One simple test of the Caesar Shift is to use a small sample of the alphabet in order. For example:
    >ABCDEFG
    Using a shift of 1 will show the Caesar Shift in action.

* Vigenere Cipher
    * The Vigenere Cipher isn't the most intuitive cipher to decode. To prove the cipher is working it might be best to compare test cases to a website such as [dcode.fr/vigenere-cipher](dcode.fr/vigenere-cipher). The example used above is a good test case to use.

## Using the DecoderEncoder
The DecoderEncoder software can be used to encode and decode messages using ciphers. 
* Encoding
    * To encode a message, type in the message you want to encode in the 'Input' text box. Then select the desired cipher from the cipher dropdown (you will need to ensure there is a value selected for the selected cipher; for Caesar, a number is needed, for Vigenere, a word is needed) then select Encode. This will spit out the encoded message in the 'Output' text box. 
* Decoding
    * To decode a message, follow the steps above but select Decode instead of Encode. (The encrypted message needs to be placed in the 'Input' text box)

## Future Ciphers
More ciphers might be added in the future.

## Inspiration
The inspiration for this project came from "The Code Book" by Simon Singh. Cryptography has always fascinated me and this project seemed like a good technical challenge.
