using System;
using System.Text;
public class StringUtil{
public static string Reverse(string input){
if(input == null){
return null;
}
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
return new string(charArray);
}
public static string ToTitleCase(string input){
if(string.IsNullOrEmpty(input)){
return input;
}
TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
return textInfo.ToTitleCase(input.ToLower());
}
public static bool IsPalindrome(string input){
if(string.IsNullOrEmpty(input)){
return false;
}
string reversed = Reverse(input);
return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
}
public static string RemoveWhitespace(string input){
if(input == null){
return null;
}
StringBuilder sb = new StringBuilder();
foreach(char c in input){
if(!char.IsWhiteSpace(c)){
sb.Append(c);
}
}
return sb.ToString();
}
public static string[] SplitByComma(string input){
if(input == null){
return new string[0];
}
return input.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
}
public static string JoinStrings(string[] strings, string separator){
if(strings == null || strings.Length == 0){
return string.Empty;
}
return string.Join(separator, strings);
}
}
