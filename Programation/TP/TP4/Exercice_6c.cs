using System;

class Exercice_6
{
    static void Main()
    {
        // Массив на 10 целых чисел.
        // При создании все ячейки содержат 0.
        int[] tab = new int[10];

        int numero;       // Число, которое пользователь хочет вставить
        int indice = 0;   // Индекс ячейки, с которой сейчас работаем
        int choix;        // Выбранный пункт меню
        int nbNumbs = 0;  // Количество действительно добавленных чисел
        int nbIndice;     // Сохранённая позиция для вставки нового числа

        // Пока true — продолжаем показывать меню.
        bool exit = true;

        while (exit)
        {
            Console.Write(
                "1 -- Afficher tableau\n" +
                "2 -- Insérer un nombre\n" +
                "3 -- Quitter\n"
            );

            Console.WriteLine("Saisir une option : ");
            choix = int.Parse(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Nombre d'éléments : " + nbNumbs);

                // Показываем ВСЕ 10 ячеек, включая незанятые.
                // Занятые ячейки имеют индексы от 0 до nbNumbs - 1.
                // Значение 0 само по себе не означает «пусто»:
                // пользователь тоже может добавить число 0.
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine(i + " : " + tab[i]);
                }
            }
            else if (choix == 2)
            {
                Console.WriteLine("Saisir un nombre : ");
                numero = int.Parse(Console.ReadLine());

                // Если заняты все ячейки, вставлять больше некуда.
                if (nbNumbs == tab.Length)
                {
                    Console.WriteLine("Le tableau est rempli!!!!\n");
                }
                else if (nbNumbs >= 1)
                {
                    // В массиве уже есть хотя бы одно число.
                    // Ищем позицию вставки, начиная с первой ячейки.
                    indice = 0;

                    // Продолжаем, пока:
                    // 1. Не дошли до конца занятой части массива.
                    // 2. Текущее число меньше нового.
                    //
                    // Остановимся перед первым числом >= numero
                    // или на первой свободной ячейке.
                    while (indice < nbNumbs && tab[indice] < numero)
                    {
                        indice++;
                    }

                    if (indice < nbNumbs)
                    {
                        // Вставка будет перед существующим элементом.
                        // Сохраняем найденную позицию.
                        nbIndice = indice;

                        // nbNumbs — индекс ПЕРВОЙ СВОБОДНОЙ ячейки.
                        // Например: 4 числа занимают индексы 0, 1, 2, 3.
                        // Значит, первая свободная ячейка — 4.
                        indice = nbNumbs;

                        // Освобождаем место для нового числа.
                        // Сдвигаем элементы ВПРАВО, начиная С КОНЦА,
                        // чтобы не уничтожить ещё не перенесённые значения.
                        while (indice > nbIndice)
                        {
                            // Копируем значение из левой ячейки в правую.
                            tab[indice] = tab[indice - 1];

                            // Переходим на одну ячейку влево.
                            indice = indice - 1;
                        }

                        // Возвращаемся к позиции вставки.
                        // После цикла indice уже равен nbIndice,
                        // поэтому это присваивание можно было бы убрать.
                        indice = nbIndice;

                        // Записываем новое число в освобождённое место.
                        tab[indice] = numero;

                        // Теперь в массиве на одно число больше.
                        nbNumbs++;
                    }
                    else
                    {
                        // Новое число больше всех существующих.
                        // indice == nbNumbs: это первая свободная ячейка.
                        // Добавляем число в конец без сдвига.
                        tab[indice] = numero;
                        nbNumbs++;
                    }
                }
                else if (nbNumbs == 0)
                {
                    // Массив ещё пуст: первое число записываем
                    // в ячейку 0 (indice сейчас равен 0).
                    tab[indice] = numero;
                    nbNumbs++;
                }
            }
            else if (choix == 3)
            {
                // Условие while станет false — меню больше не повторится.
                exit = false;
            }
            else
            {
                Console.WriteLine("Saisir un numéro correct!!");
            }
        }
    }
}