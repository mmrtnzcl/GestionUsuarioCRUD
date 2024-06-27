# Gestión de Empleados API

## Descripción

Esta es una pequeña API que gestiona los empleados de una empresa. Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) a través de los siguientes endpoints:

### Endpoints

- **Crear empleado**
  - **URL:** `/api/employee/add`
  - **Método:** POST
  - **Descripción:** Crea un nuevo empleado.

- **Eliminar empleado**
  - **URL:** `/api/employee/delete/{id}`
  - **Método:** DELETE
  - **Descripción:** Elimina un empleado por su ID.

- **Actualizar último salario**
  - **URL:** `/api/employee/{id}/ultimoSalario`
  - **Método:** PATCH
  - **Descripción:** Actualiza el último salario total de un empleado por su ID.

## Configuración de la Base de Datos

### Prerrequisitos

- Tener MySQL instalado y configurado en tu sistema.
- Crear una base de datos llamada `usuarios`.

### Configuración

1. Clona este repositorio en tu máquina local:

   git clone <url_del_repositorio>
   cd <nombre_del_proyecto>

2. Configura la cadena de connexión del archivo appettings.json, adecuando la BBDD con el nombre y el password

3. Desde el administrador de paquetes de NuGet ejecuta el siguiente comando:

	`Update-DataBase`
