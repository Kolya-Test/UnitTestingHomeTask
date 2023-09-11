# The command work training
### *Підготовка*

1. Для початку треба скопіювати репозиторій. В Git-bash виконати команду:  
        `git clone https://github.com/Kolya-Test/UnitTestingHomeTask.git`
2. У проекті "**Tools**" з поміж класів ***`Article`***, ***`User`***, ***`TextTool`***, ***`AtricleExtentions`*** обрати собі два-три методи/коструктори/властивості для тестування (які не тестуються іншими) та повідомити про вибір.
3. Налаштувати репозиторій:  
    3.1. Відкрити папку, яка утворилась та встановити ім'я користувача та електронну пошту, виконавши наступні команди:  
        `git config --local user.name "Name"`  
        `git config --local user.email "email@gmail.com"`

    > Тут замість  **`Name`**  та  **`email@gmail.com`**  вказати своє ім'я та електронну пошту через яку буде проводитися робота із сайтом [github.com](https://github.com).  
    > Також при бажанні можна використати атрибут **`--global`** замість **`--local`** для збереження параметрів для всього комп'ютера, а не лише для даного проекту.

    3.2. Створити окрему гілку для своєї роботи із назвою у вигляді свого прізвища:  
        `git checkout -b firstName`  
    > Тут замість **`firstName`** вказати своє ім'я (наприклад, ***`ivan`***, ***`petro`*** тощо). Можна дописати назви тестів/класів. Це і буде назвою нової гілки.  
    > ***Важливо:*** Для кожного має бути своя окрема гілка побудована на основі гілки **`main`** (тобто створювати її лише коли на *main*)!

    3.3. Зробити тестовий коміт.  

    Для цього зробити будь-які зміни (наприклад, у проекті **`ToolsTest`** створити файл для класу який тестується; або ж просто добавити пробіл/ентер у будь-який файл).  

    Потім виконати наступні команди:  
        `git add .`  
        `git commit -m "Connection test"`  
		
	3.4. Перевірити з'єднання.  

    Для цього виконати команду:  
        `git push -u origin firstName` 

    > Тут замість **`firstName`** вказати назву своєї гілки, створеної в пункті ***'3.2'*** (тобто співзвучної із своїм ім'ям).  
    > Під час появи повідомлення про авторизацію, обрати/натиснути 'у вікні браузера', та ввести логін (електронну пошту) та пароль, що використовуються для авторизації на сайті [github.com](https://github.com).  

    > У всіх подальших відправках на сервер (для існуючих на сервері гілок) можна використовувати спрощену команду:  
    > `git push`  

4. Перевірити появу своєї гілки у [репозиторії UnitTestingHomeTask на github](https://github.com/Kolya-Test/UnitTestingHomeTask). Це свідчитиме, що з'єднання корректне і можна працювати.  
5. Розпочати роботу із написання модульних тестів.  
    > У проекті "**Tools**" вже додано необхідні пакети основних фреймворків (***`MSTest`***, ***`nUnit`***, ***`xUnit`***), а також ***`FluentAssertions`*** і ***`Moq`***, тому нічого довстановлювати в ідеалі не потрібно!  
    > ***Важливо:*** Зберігати правильне іменування файлів і тестів та правильну структуру проекту, добавляючи нові файли у відповідні місця де це потрібно!  



## Вимоги до виконання
- Кожен має зробити по два-три методи/коструктори/властивості класів ***`Article`***, ***`User`***, ***`TextTool`***, ***`AtricleExtentions`*** проекту "**Tools**" (за бажанням та наявністю додаткового часу можна виконати ще, але окремо);  
- Можна створювати як загальний один pull-request (простіший варіант), так і окремий pull-request для кожного тесту / групи тестів (може бути дещо довше);  
- При написанні тестів використовувати один із фреймворків ***`MSTest`***, ***`nUnit`*** або ***`xUnit`*** (один фремворк для кожного окремого тесту);  
- Тести мають успішно проходити (бути зеленими), або ж у пул-реквесті має бути зазначено які саме падають та додано опис про причини неуспішного проходження тестів;  
- Pull-request повинен автоматично створюватись на основі макета *`pull_request_template`*, тому заповнити відповідні поля які там є;  
- У пул-реквесті **обов'язково** має бути присвоєний рев'ювер **`Kolya-Test`** (справа зверху);  
- У пул-реквесті для *`Assignees`* вказувати себе (відразу під рев'ювером);  
- Мерджити зі своєї гілки (тої на яку є апрувнутий пул-реквест) у гілку **`main`**, так як гілка **`dev`** не створювалася (немає потреби);  
- Мерджити можна лише після мого апруву!  




## Хто які тести робить

|   Ім'я    |    Назва класу    |              Назви методів/властивостей              |
| --------- | ----------------- | ---------------------------------------------------- |
| Антон     |     TextTool      | GetColorName(), ToCapital(), FindPosition()
| Артур     |                   |
| Василь    |                   |
| Владислав |                   |
| Володимир | AtricleExtentions | HasText(), GetCapitalTitle(), TryReplaceText()
| Олексій   |                   |
| Юрій      |                   |










