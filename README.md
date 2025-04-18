# MSFCipher

MSFCipher is a C# library that provides implementations of various classical and modern encryption algorithms using a simple, pluggable interface. Designed for learning, experimenting, and integrating symmetric encryption methods into your own .NET projects.

---

## ✨ Features

- ✅ Easy-to-use ICipher interface
- 🔐 Ciphers:
  - Caesar Cipher
  - Monoalphabetic Cipher
  - Vernam Cipher
  - One-Time Pad
  - Rail Fence Cipher
  - Row-Column Transposition Cipher




## 🧠 Interface
All cipher classes implement a common interface, making it easy to switch between different encryption methods:

```bash
public interface ICipher
{
    string Encrypt(string text);
    string Decrypt(string cipherText);
}
```


## 🚀 Usage Examples

- ✅ Caesar Cipher
```csharp
MSFCipher MSF = new MSFCipher();

ICipher cipher = MSF.GetCaesarCipher(3);
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```
- ✅ Vernam  Cipher
```csharp
MSFCipher MSF = new MSFCipher();

ICipher cipher = MSF.GetVernamCipher("TestTestTestT");
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```

- ✅ One-Time Pad  Cipher
```csharp
MSFCipher MSF = new MSFCipher();

var cipher = MSF.GetOneTimePadCipher();
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");
Console.WriteLine($"Key Used: {cipher.GetKey()}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```

- ✅ Monoalphabetic   Cipher
```csharp
MSFCipher MSF = new MSFCipher();

ICipher cipher = MSF.GetMonoalphabeticCipher("QWERTYUIOPASDFGHJKLZXCVBNM");
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```

- ✅ Row-Column Transposition Cipher
```csharp
MSFCipher MSF = new MSFCipher();

ICipher cipher = MSF.GetRowColumnTranspositionCipher(5);
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```
- ✅ Rail Fence Cipher
```csharp
MSFCipher MSF = new MSFCipher();

ICipher cipher = MSF.GetRailFenceCipher(3);
string message = "Hello, World!";
string encryptedMessage = cipher.Encrypt(message);
Console.WriteLine($"Encrypted Message: {encryptedMessage}");

string decryptedMessage = cipher.Decrypt(encryptedMessage);
Console.WriteLine($"Decrypted Message: {decryptedMessage}");
```
## 📁 Project Structure

```bash
MSFC/
│
├── Contracts/
│   ├── ICipher.cs    # Cipher interface
│   └── IMSFCipher.cs         
│
├── Entities/
│   ├── CaesarCipher.cs
│   ├── MonoalphabeticCipher.cs
│   ├── VernamCipher.cs
│   ├── OneTimePadCipher.cs
│   ├── RailFenceCipher.cs
│   └── RowColumnTranspositionCipher.cs
│
```
## 🤝 Contributing
- Pull requests are welcome! Feel free to fork this project, improve it, and submit a PR.

## 📜 License
- This project is open-source and available under the MIT License.

## 🧪 Demo
- You can quickly test each cipher by running Test/ConsoleApp1
