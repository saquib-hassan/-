using SharpAESCrypt;


string dir = @"C:/";
string plain_text_file = dir + "Money.txt";
string encrypted_file = dir + "encrypted_file.txt";

SharpAESCrypt.SharpAESCrypt.Encrypt("password",plain_text_file, encrypted_file);
