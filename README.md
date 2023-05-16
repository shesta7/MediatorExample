# MediatorExample

Тестовый проект с использованием паттерна Medator

## Пример диаграммы последовательности запроса от пользователя

```mermaid
sequenceDiagram
    participant User
    participant Controller
    participant Handler1
    participant Handler2
    participant HandlerN
    User->>Controller: Request
    Controller->>Handler1: RequestForHandler1
    Handler1->>Handler2: RequestForHandler2
    Handler2->>Handler1: ReponseFromHandler2 (inherits from BaseResponse)
    Handler1->>HandlerN: RequestForHandlerN
    HandlerN->>Handler1: ReponseFromHandlerN (inherits from BaseResponse)
    Handler1->>Controller: ReponseFromHandler1 (inherits from BaseResponse)
    Controller->>User: ReponseFromController
```
## Организация файлов
1. Application
   - ControllerName (Название папки по имени контроллера)
     - Handlers [Обработчики запросов от mediator] [namespace appname.Handlers]
        - HandlerName (Название обработчика по имени метода контроллера)
     - Mappers [Мапперы] [namespace appname.Mappers]
        - MapperName (Название_запроса_Mapper)
     - Requests [Запросы] [namespace appname.Requests]
        - RequestName (Название_метода_Request)
     - Responses [Ответы] [namespace appname.Responses]
        - RequestName (Название_метода_Response)
     - Validators [Валидаторы] [namespace appname.Validators]
        - ValidatorName (Название_запроса_Validator)
     - MediatorSender [partial class] методы Send запросов в handler'ы для медиатора
2. Controllers (контроллеры - endpoints, задача методов контроллера сформировать запрос к медиатору и отдать ответ пользователю)
3. Services (Сервисы - общие классы, в которых нет обработчиков, например CacheProvider)
