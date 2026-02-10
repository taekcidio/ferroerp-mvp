# FerroERP MVP — Documentación

Esta documentación centraliza los **diagramas UML** del proyecto y explica brevemente qué representa cada uno.

## Diagramas UML (Exportados - PNG)

1) **Diagrama de Clases** (modelo de datos y relaciones principales)  
- PNG: `../diagrams/Exports/01_class_diagram.png`  
- PUML: `../diagrams/plantuml/01_class_diagram.puml`

2) **Diagrama de Objetos** (instancia de ejemplo: compra + venta + cliente)  
- PNG: `../diagrams/Exports/02_object_diagram.png`  
- PUML: `../diagrams/plantuml/02_object_diagram.puml`

3) **Diagrama de Componentes** (frontend, API, módulos y base de datos)  
- PNG: `../diagrams/Exports/03_component_diagram.png`  
- PUML: `../diagrams/plantuml/03_component_diagram.puml`

4) **Diagrama de Despliegue (Deployment)** (cómo se ejecuta en infraestructura)  
- PNG: `../diagrams/Exports/04_deployment_diagram.png`  
- PUML: `../diagrams/plantuml/04_deployment_diagram.puml`

5) **Diagrama de Paquetes** (organización lógica por capas y dominios)  
- PNG: `../diagrams/Exports/05_package_diagram.png`  
- PUML: `../diagrams/plantuml/05_package_diagram.puml`

6) **Diagrama de Estructura Compuesta (Composite Structure)** (componentes internos del servicio de ventas)  
- PNG: `../diagrams/Exports/06_composite_structure_diagram.png`  
- PUML: `../diagrams/plantuml/06_composite_structure_diagram.puml`

---

## Cómo generar / actualizar los diagramas
1. Abrir el archivo `.puml` desde `diagrams/plantuml/`
2. Renderizar en PlantUML (PlantText, VS Code + extensión PlantUML, etc.)
3. Exportar a PNG y subirlo en `diagrams/Exports/`

---

## Resumen del proyecto (MVP)
- **Flujo general del negocio:** Proveedor → Compra → Inventario → Venta → Factura → Cliente  
- **Decisión de arquitectura:** Monolito modular (simple, escalable y apropiado para una PYME)

