# DecoderEncoder
 Application used to encode and decode messages using various types of ciphers. 
 Currently implemented ciphers:
 * Caesar Shift
 * Vigenere Cipher
## Getting Started
This is where instructions go. Once I learn how to work this thing
### Installing
Once I learn how to set up this project to install I will fill this out
## Ciphers
* Caesar Shift
    * The Caesar Shift (or Caesar Cipher) is a simple substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet. The following picture represents a Caesar Shift with a shift value of 3.

![Caesar Shift Example](https://upload.wikimedia.org/wikipedia/commons/4/4a/Caesar_cipher_left_shift_of_3.svg)

* Vigenere Cipher
    * The Vigenere Cipher is a method of encrypting alphabetic text by using a series of interwoven Caesar Shifts, based on the letters of a keyword. 
    * To encrypt, a table of alphabets can be used, a Vigenere square. It has the alphabet written out 26 times in different rows, each alphabet shifted cyclically to the left compared to the previous alphabet. 

    ![Vigenere Table](https://upload.wikimedia.org/wikipedia/commons/9/9a/Vigen%C3%A8re_square_shading.svg) 
    * For example, suppose that the plaintext to be encrypted is:
    > ATTACKATDAWN
    The person sending the message chooses a keyword and repeats it until it matches the length of the plaintext, for example, the keyword "LEMON":
    > LEMONLEMONLE
    * Each row starts with a key letter. The rest of the row holds the letters A to Z (in shifted order). Although there are 26 key rows shown, a code will use only as many keys (different alphabets) as there are unique letters in the key string, here just 5 keys: (L, E, M, O, N).
    * For example, the first letter of the plaintext, A, is paired with L, the first letter of the key. Therefore, row L and column A of the Vigenere square are used, namely L. Similarly, for the second letter of the plaintext, the second letter of the key is used. The letter at row E and column T is X. The rest of the plaintext is enciphered in a similar fashion:
    > Plaintext: ATTACKATDAWN
    > Key: LEMONLEMONLE
    > Ciphertext: LXFOPVEFRNHR