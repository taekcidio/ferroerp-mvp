# FerroERP — Plan de Pruebas Sprint 1 (Sprint 0)

## Objetivo
Definir mínimo **5 casos de prueba por historia** del Sprint 1 y dejar evidencia.

## Plantilla de casos (por historia)
- **TC-1 Flujo feliz:** datos válidos → operación exitosa
- **TC-2 Campo obligatorio:** falta dato obligatorio → error
- **TC-3 Validación de formato:** formato inválido (email, número, etc.) → error
- **TC-4 Regla de negocio:** regla específica (duplicados, stock suficiente, etc.) → error/validación
- **TC-5 Persistencia/consulta:** se guarda y luego se consulta correctamente

## Historias Sprint 1 a probar
Inventario:
- Registrar productos
- Entrada de stock
- Salida de stock
- Consultar stock

CRM:
- Registrar cliente
- Consultar clientes
- (Opcional) Registrar interacción

## Evidencias
Para cada historia se debe adjuntar:
- Captura o link del resultado de pruebas (pantalla/log)
- Link al commit/PR relacionado
