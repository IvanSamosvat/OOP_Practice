# Проєкт: Система Управління Дронами для Обробки Полів

Було розроблено модель предметної області, що дозволяє автоматизувати обробку полів дронами для посіву, моніторингу, внесення добрив та зрошення. 

## Основні класи системи

### 1. **DroneSystemManager**
**Опис:** Клас відповідає за управління всією системою дронів, місій, полів і базових станцій в межах автоматизованої системи.

**Атрибути:**
- `drones`: Список всіх дронів у системі.
- `missions`: Список всіх місій.
- `fields`: Список всіх полів.
- `baseStations`: Список базових станцій.

**Методи:**
- `addDrone()`, `removeDrone()`: Додають або видаляють дронів із системи.
- `addMission()`, `cancelMission()`: Додають нові місії або скасовують їх.
- `monitorSystem()`: Перевіряє стан системи.
- `assignMissionToDrone()`: Призначає місію дрону.
- `getSystemStatus()`: Отримує загальний стан системи.
- `getDronesCount()`: Повертає кількість дронів у системі.

---

### 2. **Drone**
**Опис:** Клас описує конкретний дрон, який використовується на фермі.

**Атрибути:**
- `id`: Унікальний ідентифікатор дрону.
- `type`: Тип дрону (моніторинг, посів, зрошення).
- `batteryLevel`: Рівень заряду батареї.
- `status`: Статус дрону (активний, заряджається, несправний).
- `location`: Поточне місцезнаходження дрону.

**Методи:**
- `startMission()`, `returnToBase()`: Запускає місію або повертає дрон на базу.
- `updateBatteryLevel()`, `updateLocation()`: Оновлює рівень заряду і місцезнаходження.
- `selfCheck()`: Перевіряє стан дрону.
- `monitor()`, `assign()`, `updateStatus()`: Відповідають за моніторинг, призначення місій і оновлення статусу.

---

### 3. **Mission**
**Опис:** Клас представляє місію, яку виконують дрони.

**Атрибути:**
- `id`: Унікальний ідентифікатор місії.
- `type`: Тип місії (посів, зрошення, моніторинг).
- `area`: Територія, де виконується місія.
- `status`: Статус місії (в черзі, в процесі, завершена).
- `assignedDrone`: Дрон, призначений для виконання місії.

**Методи:**
- `assignDrone()`, `completeMission()`: Призначає дрону місію або завершує її.
- `updateArea()`, `cancelMission()`: Оновлює територію або скасовує місію.
- `updateStatus()`: Оновлення статусу місії.

---

### 4. **Field**
**Опис:** Клас представляє поле, яке обслуговують дрони.

**Атрибути:**
- `id`: Унікальний ідентифікатор поля.
- `location`: Місцезнаходження поля.
- `cropType`: Тип вирощуваних культур.
- `status`: Статус поля (необхідно зрошення, посів, нормальний стан).

**Методи:**
- `updateStatus()`, `getFieldDetails()`: Оновлює статус або отримує інформацію про поле.
- `needsMaintenance()`, `monitor()`: Перевіряє стан поля або здійснює моніторинг.

---

### 5. **BaseStation**
**Опис:** Клас представляє базову станцію, що обслуговує дронів.

**Атрибути:**
- `id`: Унікальний ідентифікатор базової станції.

**Методи:**
- `addDrone()`, `removeDrone()`: Додає або видаляє дронів зі станції.
- `assignMission()`: Призначає місію дрону.
- `monitorDrones()`, `getStationDetails()`: Моніторить стан дронів або отримує деталі станції.
- `getAvailableDronesCount()`: Повертає кількість доступних дронів.

---

## Інтерфейси

- **Monitorable:** Визначає метод `monitor()` для моніторингу об’єктів.
- **Assignable:** Визначає метод `assign()` для призначення місій.
- **StatusUpdatable:** Визначає метод `updateStatus()` для оновлення статусів об’єктів.

---

## Перелічення (Enums)
- **DroneType:** Типи дронів (моніторинг, посів, зрошення).
- **DroneStatus:** Статуси дрону (активний, заряджається, несправний).
- **MissionType:** Типи місій (посів, зрошення, моніторинг).
- **MissionStatus:** Статуси місії (в черзі, в процесі, завершена).
- **FieldStatus:** Статуси поля (необхідно зрошення, необхідно посів, нормальний стан).

---

## Архітектурна діаграма
@startuml

class DroneSystemManager {
    - drones: List<Drone>
    - missions: List<Mission>
    - fields: List<Field>
    - baseStations: List<BaseStation>
    + addDrone(drone: Drone): void
    + removeDrone(drone: Drone): void
    + addMission(mission: Mission): void
    + cancelMission(mission: Mission): void
    + monitorSystem(): void
    + assignMissionToDrone(mission: Mission, drone: Drone): void
    + getSystemStatus(): String
}

class Drone {
    - id: int
    - type: DroneType
    - batteryLevel: int
    - status: DroneStatus
    - location: String
    + startMission(mission: Mission): void
    + returnToBase(): void
    + updateBatteryLevel(level: int): void
    + updateLocation(newLocation: String): void
    + selfCheck(): void
}

class Mission {
    - id: int
    - type: MissionType
    - area: String
    - status: MissionStatus
    + assignDrone(drone: Drone): void
    + completeMission(): void
    + updateArea(newArea: String): void
    + cancelMission(): void
}

class Field {
    - id: int
    - location: String
    - cropType: String
    - status: FieldStatus
    + updateStatus(status: FieldStatus): void
    + getFieldDetails(): String
    + needsMaintenance(): boolean
}

class BaseStation {
    - id: int
    - availableDrones: List<Drone>
    - missionQueue: Queue<Mission>
    + addDrone(drone: Drone): void
    + assignMission(mission: Mission): void
    + monitorDrones(): void
    + removeDrone(drone: Drone): void
    + getStationDetails(): String
}

interface Monitorable {
    + monitor(): void
}

interface Assignable {
    + assign(object: Object): void
}

interface StatusUpdatable {
    + updateStatus(status: Enum): void
}

enum DroneType {
    MONITORING
    SEEDING
    IRRIGATION
}

enum DroneStatus {
    ACTIVE
    CHARGING
    MALFUNCTION
}

enum MissionType {
    SEEDING
    IRRIGATION
    MONITORING
}

enum MissionStatus {
    QUEUED
    IN_PROGRESS
    COMPLETED
}

enum FieldStatus {
    NEEDS_IRRIGATION
    NEEDS_SEEDING
    NORMAL
}

DroneSystemManager "1" *-- "*" Drone
DroneSystemManager "1" *-- "*" Mission
DroneSystemManager "1" *-- "*" Field
DroneSystemManager "1" *-- "*" BaseStation

BaseStation "1" o-- "*" Drone
BaseStation "1" o-- "*" Mission

Mission --> "1" Drone
Field --> "1" Mission

Drone --|> Monitorable
Drone --|> Assignable
Drone --|> StatusUpdatable

Mission --|> Assignable
Mission --|> StatusUpdatable

Field --|> Monitorable
Field --|> StatusUpdatable

DroneType --> Drone
DroneStatus --> Drone
MissionType --> Mission
MissionStatus --> Mission
FieldStatus --> Field

@enduml
