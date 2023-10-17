using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using OtusSolidHomeWork;
using OtusSolidHomeWork.Interfases;




Settings settings = new Settings(3, 1, 20);
IRandomizer random = new Randomizer();
IConsoleInput input = new ConsoleIO();
IConsoleOutput output = new ConsoleIO();
IGame _game = new Game(settings, random, input, output);

_game.Start();
