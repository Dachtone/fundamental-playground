using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(12)]
    public class CodePack12 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter day")]
        [InputMessage(0, "ru", "Введите день")]
        [InputMessage(1, "en", "Enter month")]
        [InputMessage(1, "ru", "Введите месяц")]
        [OutputMessage("en", "Date")]
        [OutputMessage("ru", "Дата")]
        public string Date(int day, int month)
        {
            StringBuilder date = new StringBuilder("");

            if (day / 10 == 1)
            {
                string[] numberParts =
                {
                    "Один",
                    "Две",
                    "Три",
                    "Четыр",
                    "Пят",
                    "Шест",
                    "Сем",
                    "Восем",
                    "Девят"
                };
                date.Append(numberParts[day % 10 - 1]);
                date.Append("надцатое");
            }
            else
            {
                switch (day / 10)
                {
                    case 2:
                        date.Append("Двадцать ");
                        break;
                    case 3:
                        date.Append("Тридцать ");
                        break;
                }

                switch (day % 10)
                {
                    case 0:
                        date.Remove(date.Length - 2, 2);
                        date.Append("ое ");
                        break;
                    case 1:
                        date.Append(((day / 10 == 0) ? "П" : "п") + "ервое");
                        break;
                    case 2:
                        date.Append(((day / 10 == 0) ? "В" : "в") + "торое");
                        break;
                    case 3:
                        date.Append(((day / 10 == 0) ? "Т" : "т") + "ретье");
                        break;
                    case 4:
                        date.Append(((day / 10 == 0) ? "Ч" : "ч") + "етвёртое");
                        break;
                    case 5:
                        date.Append(((day / 10 == 0) ? "П" : "п") + "ятое");
                        break;
                    case 6:
                        date.Append(((day / 10 == 0) ? "Ш" : "ш") + "естое");
                        break;
                    case 7:
                        date.Append(((day / 10 == 0) ? "С" : "с") + "едьмое");
                        break;
                    case 8:
                        date.Append(((day / 10 == 0) ? "В" : "в") + "осьмое");
                        break;
                    case 9:
                        date.Append(((day / 10 == 0) ? "Д" : "д") + "евятое");
                        break;
                }
            }

            date.Append(" ");

            string[] monthNames =
            {
                "января",
                "февраля",
                "марта",
                "апреля",
                "мая",
                "июня",
                "июля",
                "августа",
                "сентября",
                "октября",
                "ноября",
                "декабря",
            };
            date.Append(monthNames[month - 1]);

            return date.ToString();
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter C")]
        [InputMessage(0, "ru", "Введите C")]
        [InputMessage(1, "en", "Enter N")]
        [InputMessage(1, "ru", "Введите N")]
        [OutputMessage("en", "Direction")]
        [OutputMessage("ru", "Направление")]
        public char Rotation(char c, int n)
        {
            char[] directions =
            {
                'С',
                'З',
                'Ю',
                'В'
            };

            int directionIndex = -1;
            for (int i = 0; i < 4; i++)
            {
                if (directions[i] == c)
                {
                    directionIndex = i;
                    break;
                }
            }

            if (directionIndex == -1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Invalid C" },
                    { "ru", "Указанная сторона не существует" }
                });
            }

            if (n < -1 || n > 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Invalid command" },
                    { "ru", "Указанная команда не существует" }
                });
            }

            directionIndex += n;
            if (directionIndex < 0)
                directionIndex = 4 + directionIndex;

            return directions[directionIndex % 4];
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Description")]
        [OutputMessage("ru", "Описание")]
        public string NumberOfTasksDescription(int number)
        {
            if (number < 10 || number > 40)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must lie in [10; 40]" },
                    { "ru", "Число должно находиться в пределе [10; 40]" }
                });
            }

            StringBuilder description = new StringBuilder("");

            string[] tens =
            {
                "Десять",
                "Двадцать",
                "Тридцать",
                "Сорок"
            };

            if (number == 10)
            {
                description.Append(tens[0]);
            }
            else
            {
                if (number / 10 == 1)
                {
                    string[] numberTeenParts =
                    {
                        "Один",
                        "Две",
                        "Три",
                        "Четыр",
                        "Пят",
                        "Шест",
                        "Сем",
                        "Восем",
                        "Девят"
                    };
                    description.Append(numberTeenParts[number % 10 - 1]);
                    description.Append("надцать");
                }
                else
                {
                    description.Append(tens[number / 10 - 1]);

                    if (number % 10 != 0)
                    {
                        description.Append(" ");

                        string[] numberTeenParts =
                        {
                            "одно",
                            "два",
                            "три",
                            "четыре",
                            "пять",
                            "шесть",
                            "семь",
                            "восемь",
                            "девять"
                        };
                        description.Append(numberTeenParts[number % 10 - 1]);
                    }
                }
            }

            description.Append(" учебн");
            if (number % 10 == 1 && number / 10 != 1)
            {
                description.Append("ое");
            }
            else
            {
                description.Append("ых");
            }

            description.Append(" задан");
            if (number / 10 == 1)
            {
                description.Append("ий");
            }
            else
            {
                switch (number % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        description.Append("ий");
                        break;
                    case 1:
                        description.Append("ие");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        description.Append("ия");
                        break;
                }
            }

            return description.ToString();
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Description")]
        [OutputMessage("ru", "Описание")]
        public string NumberDescription(int number)
        {
            if (number < 100 || number > 999)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must lie in [100; 999]" },
                    { "ru", "Число должно находиться в пределе [100; 999]" }
                });
            }

            StringBuilder description = new StringBuilder("");

            string[] hundreds =
            {
                "Сто",
                "Двести",
                "Триста",
                "Четыреста",
                "Пятьсот",
                "Шестьсот",
                "Семьсот",
                "Восемьсот",
                "Девятьсот"
            };
            description.Append(hundreds[number / 100 - 1]);

            if (number % 100 != 0)
            {
                description.Append(" ");

                if (number % 100 == 10)
                {
                    description.Append("десять");
                }
                else if (number / 10 % 10 == 1)
                {
                    string[] teenPart =
                    {
                        "один",
                        "две",
                        "три",
                        "четыр",
                        "пят",
                        "шест",
                        "сем",
                        "восем",
                        "девят"
                    };
                    description.Append(teenPart[number % 10 - 1]);
                    description.Append("надцать");
                }
                else
                {
                    if (number / 10 % 10 != 0)
                    {
                        string[] tens =
                        {
                            "двадцать",
                            "тридцать",
                            "сорок",
                            "пятьдесят",
                            "шестьдесят",
                            "семьдесят",
                            "восемьдесят",
                            "девяносто"
                        };
                        description.Append(tens[number / 10 % 10 - 2]);

                        description.Append(" ");
                    }

                    string[] ones =
                    {
                        "один",
                        "два",
                        "три",
                        "четыре",
                        "пять",
                        "шесть",
                        "семь",
                        "восемь",
                        "девять"
                    };
                    description.Append(ones[number % 10 - 1]);
                }
            }

            return description.ToString();
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter a year")]
        [InputMessage(0, "ru", "Введите год")]
        [OutputMessage("en", "Title")]
        [OutputMessage("ru", "Название")]
        public string YearTitle(int year)
        {
            StringBuilder title = new StringBuilder("Год ");

            int offset = year - 1984;
            if (offset < 0)
                offset = 60 + offset % 60;

            string[] colorParts =
            {
                "зелён",
                "красн",
                "жёлт",
                "бел",
                "чёрн"
            };
            title.Append(colorParts[offset / 12 % 5]);
            if (offset % 12 >= 2 && offset % 12 <= 4)
            {
                title.Append("ого");
            }
            else
            {
                title.Append("ой");
            }

            title.Append(" ");

            string[] animal =
            {
                "крысы",
                "коровы",
                "тигра",
                "зайца",
                "дракона",
                "змеи",
                "лошади",
                "овцы",
                "обезьяны",
                "курицы",
                "собаки",
                "свиньи",

            };
            title.Append(animal[offset % 12]);

            return title.ToString();
        }
        #endregion
    }
}
