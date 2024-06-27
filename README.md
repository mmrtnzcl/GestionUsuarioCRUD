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
  - **URL:** `/api/employee/{id}/updateLastSalary`
  - **Método:** PUT
  - **Descripción:** Actualiza el último salario total de un empleado por su ID.
  
  - **Obtener todos los empleados**
  - **URL:** `/api/employee/all`
  - **Método:** GET
  - **Descripción:** Obtiene todos los empleados de la BBDD.
  
  - **Obtener empleado por ID**
  - **URL:** `/api/employee/{id}`
  - **Método:** GET
  - **Descripción:** Obtiene los datos del empleado por su ID.
  
  - **Actualizar todos los campos de un empleado**
  - **URL:** `/api/employee/update/{id}`
  - **Método:** POST
  - **Descripción:** Actualiza los datos del empleado, teniendo en cuenta los campos requeridos.
  
  - **Salario del empleado**
  - **URL:** `/api/employee/salary/{id}`
  - **Método:** GET
  - **Descripción:** Obtiene el salario de un empleado, seguún el tipo de empleado.

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
	
	Este paso, crea la BBDD y la tabla `employees` 

## Dependencias

1. Desarrollado en ASP .NET y las siguientes dependencias:
	EntityFramework Core 6.0.31
	EntityFramework Core Tools 6.0.31
	Pomelo EntityFramework Core MySQL 6.0.3
