test-rabbit-communication
=========================

Repository with 2 services which communicate via RabbitMQ.

Started as a test task, but continued as a project for testing architecture questions (DDD, CQRS, etc)

<details><summary>Test task content</summary>

### Стэк

- net5+
- MediatR
- MassTransit(реализует паттерн шины для RabbitMq)
- AutoMapper (приведение одних типов классов к другим)
- Serilog
- Entity Framework Core
- Docker
- Postgres
- FluentValidation

### Задание

В Docker поднять:
- RabbitMq
- 2 сервиса которые будут между собой общаться по шине
- БД любую из перечисленных

#### 1 сервис ([Test.Rabbit.Producer](services\Test.Rabbit.Producer)):
- Принимает запросы типа post (имя, фамилия, отчество, номер, email)
- Предусмотреть простую валидацию что все кроме отчества должно быть заполнено.
- В бизнес логике этого запроса отправлять по шине полученную информацию на 2 сервис.
- При отправке в консоль выводить логирование (сообщение о отправке вышеперечисленных данных)

#### 2 сервис ([Test.Rabbit.Consumer](services\Test.Rabbit.Consumer)):
- Принять сообщение с шины и положить его в БД (таблица Users) и залогировать это в консоль.
- У сервиса есть post запрос который связывает пользователя с организацией (таблица Organizations)
- Post-запрос который возвращает пагинацию пользователей по организации. (когда возвращаем ответ используем AutoMapper)
- При старте сделать seed в БД если там ничего нет.

#### БД:
- Таблица Users:
  Ключ пользователя + Ключ организации к которой привязан пользователь + Информация о пользователе
- Таблица Organizations:
  Ключ организации + Название организации

Написать юнит тесты


</details>


### TODOs: 
- research monorepository and submodules ()
- add precommitmessage hook to add service name to message