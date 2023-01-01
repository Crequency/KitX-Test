<Query Kind="Statements" />

using System.Text;
using System.Text.Json;

var arr = new byte[5]{ 0xf1, 0xf2, 0xf3, 0xf4, 0xf5 };
var arr2 = new byte[5]{ 0x01, 0x02, 0x03, 0x04, 0x05 };
var json = JsonSerializer.Serialize(arr);
var json2 = JsonSerializer.Serialize(arr2);

json.Dump();
json2.Dump();

