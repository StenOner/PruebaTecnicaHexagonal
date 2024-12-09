# PruebaTecnicaHexagonal

Prueba Tecnica para un aplicativo para crear categorias y productos asociados a estos.
Se utilizo una arquitectura hexagonal con el motivo de cumplir con los lineamientos especificados.

## Correr la app

Antes de ejecutar la aplicacion es necesario aplicar las migraciones del repositorio EF.

```bash
update-database -p PruebaTecnicaHexagonal.RepositoryEFCore -s PruebaTecnicaHexagonal.RepositoryEFCore
```

Una vez aplicada la migracion, se podra correr el aplicativo.

## Rutas

Las siguientes rutas se encuentran disponibles.

```bash
GET    /api/categorias
GET    /api/categorias/{id}
POST   /api/categorias
PUT    /api/categorias/{id}
DELETE /api/categorias/{id}

GET    /api/productos  (optional Parameter) categoryId
GET    /api/productos/{id}
POST   /api/productos
PUT    /api/productos/{id}
DELETE /api/productos/{id}

GET    /api/reportes/categorias
```
