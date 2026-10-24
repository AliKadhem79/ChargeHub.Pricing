```mermaid
classDiagram
    class IReportable {
        <<interface>>
        +GetReport() string
    }

    class Vehicle

    class ChargingStation {
        <<abstract>>
        +string Id
        +double MaxKw
        +CalculatePrice(decimal kwh) decimal*
        +GetReport() string
    }

    ChargingStation <|-- AcStation
    ChargingStation <|-- DcStation

    ChargingStation ..|> IReportable
    Vehicle ..|> IReportable
    ```