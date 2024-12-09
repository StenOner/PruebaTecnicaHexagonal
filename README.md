# PruebaTecnicaHexagonal

Prueba Tecnica para un aplicativo para crear categorias y productos asociados a estos.
Se utilizo una arquitectura hexagonal con el motivo de cumplir con los lineamientos especificados.

## Correr la app

Antes de ejecutar la aplicacion es necesario aplicar las migraciones del repositorio EF.

```bash
update-database -p PruebaTecnicaHexagonal.RepositoryEFCore -s PruebaTecnicaHexagonal.RepositoryEFCore
```

Una vez aplicada la migracion, se podra correr el aplicativo.
