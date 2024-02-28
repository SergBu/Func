// See https://aka.ms/new-console-template for more information

using Func;

//var date = DateTime.Now;
DateTimeHelper.OverrideNow(() => DateTime.Today.AddHours(10).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second));
DateTimeHelper.OverrideNowUtc(() => DateTime.Today.AddHours(7).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second));
var date = DateTimeHelper.Now();

var date2 = DateTimeHelper.UtcNow().AddHours(3);

Console.WriteLine("Hello, World!");
