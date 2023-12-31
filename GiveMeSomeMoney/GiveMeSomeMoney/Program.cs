using SharpAESCrypt;


string dir = @"C:/Money.txt";
string cText = "Give me some money.Give me some money.Give me some money." +
               "Give me some money.Give me some money.Give me some money." +
               "Give me some money.Give me some money.Give me some money." +
               "Give me some money.Give me some money.Give me some money." + Environment.NewLine;
File.WriteAllText(dir, cText);
string rText = File.ReadAllText(dir);
string encrypted_file = dir + "encrypted_file.txt";
SharpAESCrypt.SharpAESCrypt.Encrypt("password", dir, encrypted_file);

