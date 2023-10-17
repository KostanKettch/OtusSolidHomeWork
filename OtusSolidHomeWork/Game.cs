using OtusSolidHomeWork.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidHomeWork
{
    public class Game : IGame
    {
        private readonly ISettings _settings;
        private readonly IRandomizer _randomizer;
        private readonly IConsoleInput _consoleInput;
        private readonly IConsoleOutput _consoleOutput;


        public Game(ISettings settings, IRandomizer randomizer, IConsoleInput input, IConsoleOutput output)
        {
            _settings = settings;
            _randomizer = randomizer;
            _consoleInput = input;
            _consoleOutput = output;
        }

        public void Start()
        {
            while (true)


            {
                int rnd = _randomizer.Randomize(_settings.Min, _settings.Max);

                _consoleOutput.Write($"Загадано число от {_settings.Min} до {_settings.Max}. У тебя {_settings.Attempts} попыток");

                for (int i = 0; i <= _settings.Attempts; i++)
                {
                    int number = Convert.ToInt32(_consoleInput.ReadLine());

                    if (number == rnd)
                    {
                        _consoleOutput.Write("Когратулейшен! Ты угадал");
                        break;
                    }
                    else if (number > rnd)
                    {
                        _consoleOutput.Write("Меньше!");
                        _consoleOutput.Write($"Осталось {_settings.Attempts - i} попыток");
                    }
                    else if (number < rnd)
                    {
                        _consoleOutput.Write("Больше!");
                        _consoleOutput.Write($"Осталось {_settings.Attempts - i} попыток");
                    }
                    else if (i == _settings.Attempts)
                    {
                        _consoleOutput.Write("Попыток  больше нет ты проиграл");
                        break;
                    }
                }
                _consoleOutput.Write("Хочешь сыграть еще раз? Y/N");
                string input = _consoleInput.ReadLine();

                if (input == "N")
                {
                    break;
                }
                else if (input == "Y") { }
                
                else return;


               
            }
        }
    }
}
