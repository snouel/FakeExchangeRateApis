# Fake Exchange Rate APIs

Este repositorio contiene 3 APIs en .NET diseñadas para simular proveedores externos de tipos de cambio.  
Cada API devuelve la conversión de un monto a una tasa fija en distintos formatos:

- **FakeApi1** → JSON
- **FakeApi2** → JSON anidado
- **FakeApi3** → XML

Estas APIs sirven como entornos de prueba para BestRateFinder.

## Estructura del Proyecto

<img width="348" height="612" alt="image" src="https://github.com/user-attachments/assets/a86307fd-7603-47b2-8020-b8b564e08ffd" />


##  Levantar con Docker Compose

```bash
docker-compose up --build

Esto levantará:

FakeApi1 → http://localhost:5001

FakeApi2 → http://localhost:5002

FakeApi3 → http://localhost:5003

Ejemplo de Petición

curl -X POST http://localhost:5003/api/rate3 \
  -H "Content-Type: application/xml" \
  -d "<XmlRequest><Amount>100</Amount></XmlRequest>"

Respuesta esperada:
<XML><Result>6001</Result></XML>
