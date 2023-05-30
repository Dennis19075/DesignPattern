// See https://aka.ms/new-console-template for more information
using DesignPattern.Singleton;

Console.WriteLine("Hello, World!");

var singleton = Singleton.Instance;

var log = Log.Instance;

log.Save("saito");
log.Save("inosaka");

var a = Singleton.Instance;
var b = Singleton.Instance;

Console.WriteLine(a == b);