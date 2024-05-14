# Практична робота №1
**Варіант 2**: TextBox для введення цілих чисел із різними кольорами позитивних, негативних і нульового значень.
## Теоретичний матеріал
Зазвичай, для створення власного компонента на C# необхідно створити свій клас, що є похідним від однієї з базових класів. Базовий клас вибирається на основі вимог до рівня функціональної складності інтерфейсу компонента що розроблюється. У середовищі розробки Visual Studio пропонуються такі стандартні базові класи платформи .Net для створення власних компонентів:
Component – для створення невізуальних (без інтерфейсу користувача) компонентів з мінімальною стандартною функціональністю.
Control – для створення нестандартних візуальних компонентів, у яких зовнішній вигляд (зображення) повністю контролює та реалізує розробник.
UserControl – контейнер для об'єднання та управління існуючих елементів управління як єдиного компонента та по суті є аналогом форми (клас Form). Таким чином використання даного класу як базового дозволяє розширити функціональність компонента, що розробляється як за рахунок успадкування, так і за рахунок агрегації з іншими компонентами.
Крім перерахованих вище як базовий клас може виступати практично будь-який з елементів управління, що знаходяться на панелі інструментів (Toolbox), тому що всі вони спадкоємці як мінімум класу Component.
При створенні компонента слід враховувати, що для повторного використання в інших проектах необхідно розмістити код в окремій бібліотеці (Class Library), яка додається до панелі інструментів.
## Графічний матеріал
## ВИСНОВОК
Створено додаток, який складається з двох програмних одиниць – бібліотеки з компонентом та файлу, що запускається та використовує компонент із бібліотеки. Розроблено компонент шляхом об'єднання декількох стандартних компонентів в один власний. Оформлено звіт.
