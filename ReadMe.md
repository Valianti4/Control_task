# Итоговая контрольная работа.

1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах).

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения

1. Создаём приглашение, в котором пользователь вводит количество строк, из которого будет состоять начальный массив. Эти строки будут элементами массива.
2. Создаём строковый массив "array1" с размером "s", равным "size" и аргументом "args".
3. Создаём метод "string[] CreateArray1", в котором пользователь будет заполнять массив и этот массив будет возвращаться.
4. В этом методе инициализируем цикл, в котором пользователь будет заполнять элементы символами. В цикле прописываем условие, при соблюдении которого цикл будет повторяться. Инициализируем счётчик количества элементов (i = 0) и, пока i меньше количества элементов массива, пользователь продолжает заполнять строки и к каждой строке прибавляется 1 (i++).
5. Когда "i" становится равным количеству элементов массива, цикл останавливается и программа выводит в консоль только что созданный начальный строковый массив (вывод также был оформлен в отдельный метод).
6. Теперь нужно создать второй итоговый массив. Для этого, создаём метод "string[] CreateArray2", в котором и будут осуществляться все последующие действия.
7. Чтобы создать метод "string[] CreateArray2", только что созданный массив мы передаём в этот метод, чтобы, создавая итоговый массив, мы брали данные из начального массива.
8. Инициализируем размер итогового массива (int size = 0). Инициализируем количество символов в каждом элементе этого массива и делаем его равному 3 (int length = 3).
9. Создаём цикл, в котором инициализируем счётчик количества символов (i = 0) и, пока i меньше количества символов каждого элемента массива, при условии, что количество символов меньше, или равно 3 (если нет, то к размеру добавляется 1 (size++)), к нему прибавляется 1 (i++). Этот цикл нужен для того, чтобы перебрать все элементы начального массива и отобрать только те, что соответствуют условию задачи и создать новый размер итогового массива.
10. Далее, чтобы записать эти элементы в итоговый массив, нам нужно ещё раз пройтись по тому же самому массиву с теми же условиями, только теперь вместо увеличения размера массива, нам надо скопировать нужные элементы, для чего создаётся ещё одна итерируемая переменная (j = 0).
11. Мы снова перебираем все элементы начального массива с тем же условием, как и в пункте 9, но на сей раз при его выполнении мы из начального массива добавляем в новый массив все нужные элементы, увеличивая новую переменную "j" на единицу (j++).
12. Возвращаем получившийся итоговый массив.
13. Наконец, выводим все методы, с помощью которых создавалась программа. 