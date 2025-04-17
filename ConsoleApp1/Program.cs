﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ConsoleApp1.src.Coffeeshop.BaseComponents;
using ConsoleApp1.src.Coffeeshop.Decorators;
using ConsoleApp1.src.Coffeeshop.Interfaces;
using ConsoleApp1.src.Facade.Easy.MediaPlayer;
using ConsoleApp1.src.Flyweight.Easy.Shapes;
using ConsoleApp1.src.Proxy.Easy.ImageLoader;
using GameCharacter.Arena;
using GameCharacter.Base;
using GameCharacter.Components;
using GameCharacter.Decorators;

namespace ConsoleApp1;

static class Program {
    static void Main(string[] args) {

        //IBeverage beverage = new Espresso();
        //Console.WriteLine(beverage.GetDescription() + " $" + beverage.GetCost());

        //IBeverage beverage2 = new Espresso();
        //beverage2 = new WithMilk(beverage2);
        //beverage2 = new withMocha(beverage2);
        //Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.GetCost());

        //Console.WriteLine("Hello, World!");

        //Character warrior = new Warrior("Hercules");
        //warrior.DisplayStats();
        //// warrior = new WithWeapon(warrior,"Excalibur",1000);
        //warrior.DisplayStats();

        //Character mage = new Mage("Merlin");
        //mage.DisplayStats();

        //Arena arena = new Arena(warrior,mage);
        //arena.StartFight();

        // Facade Pattern Code

        //IMediaPlayer player = new MediaPlayerFacade();
        //player.PlayMedia(MediaTypes.Audio, "Siyah");
        //player.PlayMedia(MediaTypes.Video, "Shameless");
        //player.PlayMedia(MediaTypes.Subtitle, "Verses");

        // Flyweight pattern Code

        //CircleFactory circleFactory = new CircleFactory();
        //IShape redCircle = circleFactory.GetCircle("Red");
        //redCircle.draw(new CircleContext(3, 4));
        //IShape blueCircle = circleFactory.GetCircle("Blue");
        //blueCircle.draw(new CircleContext(1, 2));
        //IShape newCircle = circleFactory.GetCircle("Red");
        //newCircle.draw(new CircleContext(6, 9));

        // Proxy Pattern Code

        IImage funImage = new ProxyImage();
        funImage.display("fun.png");
    }
}