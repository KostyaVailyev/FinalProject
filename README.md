# FinalProject

## Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения:

1 шаг: задание массива на старте выполнения программы.
2 шаг: в методе findCount находил количество таких элементов в firstArray, у которых длина элемента <= 3 .
3 шаг: в методе createArrray сначала объявил массив с ранее найденной длиной (из метода findCount). Также объявил переменную order для того, чтобы добавилять элемент на эту позицию в цикле. Затем с помощью цикла for и условия на длину элемента, я добавлял подходящий элемент из первого массива во второй на позицию order и увеличивал order на 1. Метод возвращает второй массив.
4 шаг: присвоил новой переменной secondArray массив, который возвращается с метода createArray в основной программе.
5 шаг: метод getArray принимает мой второй массив и с помощь foreach я делал выборку по элементам в моем массиве и выводил его.
6 шаг: Вывод secondArray массива через метод gerArray().