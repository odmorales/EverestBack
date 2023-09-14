# EverestBack
## Pasos para inicializar la APP
1. Clonar el proyecto del repositorio con git clone
2. Precionar en el boton play para iniciar la API
3. Crear un contenedor de SQL para poder ejecutar la API sin problemas
   ![image](https://github.com/odmorales/EverestBack/assets/62962532/149e1988-3c35-419a-a7f8-5e55e760d632)
4. docker build -t sql-server .
5. docker run -d --name mi-sql-container -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=TuContraseña" -p 1433:1433 mi-sql-server
## Ejecutar las migraciones
1. Ir a tools en Visial Studio y abrir la consola de paquetes nugget
2. Parase en el proyecto Data y ejecutar los siguientes comandos
   Add-Migration "Initial-Migration" -Context ProductDbContext
   Update-Database -Context ProductDbContext
