# Принципи програмування у лабораторній роботі

Ця лабораторна робота демонструє використання наступних принципів програмування:

## DRY (Don't Repeat Yourself)

Код мінімізує повторення. Наприклад, метод `Subtract` у класі `Money` використовується для зменшення суми, уникаючи повторення логіки розрахунку.

## KISS (Keep It Simple, Stupid)

Кожен клас має чітке та просте призначення, що спрощує розуміння та підтримку коду.

## SOLID

### Single Responsibility Principle

Клас `Money` відповідає лише за управління грошовими сумами, `Product` - за інформацію про продукт, тощо.

### Open/Closed Principle

Класи розроблені таким чином, що до них можна додавати нову функціональність без зміни існуючого коду.

### Liskov Substitution Principle

Інтерфейси `IProduct` та `IWarehouse` дозволяють замінювати об'єкти їх реалізаціями без зміни правильності роботи програми.

### Interface Segregation Principle

Розділення функціональності між інтерфейсами `IProduct`, `IWarehouse`, і `IReporting` дозволяє класам реалізовувати тільки необхідні інтерфейси.

### Dependency Inversion Principle

Компоненти системи залежать від абстракцій, а не від конкретних реалізацій, що демонструється через використання інтерфейсів.

## YAGNI (You Aren't Gonna Need It)

Функціональність, реалізована в коді, обмежується тим, що безпосередньо необхідно для виконання поставлених задач.

## Composition Over Inheritance

Використовується композиція об'єктів, замість наслідування, для досягнення більшої гнучкості у взаємодії між компонентами.

## Program to Interfaces not Implementations

Класи програмуються до інтерфейсів, що забезпечує високий рівень абстракції та гнучкості в системі.

## Fail Fast

Система активно перевіряє вхідні дані на коректність та швидко виявляє помилки, що підвищує її надійність.
