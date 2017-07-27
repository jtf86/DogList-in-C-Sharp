// using Xunit;
// using System;
//
// namespace DogList.Objects
// {
//   public class DogListTests
//   {
//
//     [Fact]
//     public void Dog_HasName_True()
//     {
//       Dog newDog = new Dog("Kesa");
//       Assert.Equal("Kesa", newDog.GetName());
//     }
//
//     [Fact]
//     public void Dog_HasName_False()
//     {
//       Dog newDog = new Dog("Doug");
//       Assert.NotEqual("Kesa", newDog.GetName());
//     }
//
//     [Fact]
//     public void Dog_SavesToDatabaseGetsAssignedId_True()
//     {
//       Dog newDog = new Dog("Doug");
//       newDog.Save();
//
//       Console.WriteLine(newDog.GetId());
//       Dog foundDog = Dog.Find(newDog.GetId());
//
//       Assert.Equal("Doug", foundDog.GetName());
//     }
//
//
//   }
// }
