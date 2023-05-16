# MediatorExample

Тестовый проект с использованием паттерна Medator


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
