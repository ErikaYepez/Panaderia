# Panadería BACKEND
Como posible solución al escenario planteado, se desarrollo web services que trabajan con 3 tablas principales (Cliente,Producto,Orden). Se Utilizo con:<br/>
+ <b>Framework:</b> .Net<br/>
+ <b>Base de Datos:</b> SQL SERVER<br/>

<b>Arquitectura </b><br />
La solución Panaderia contiene 2 proyectos:<br />
+ Capa lógica -> Panaderia.BL <br/>
 Data: Context para accesoo a datos<br/>
 DTOS: Clases para el mapeo<br/>
 Model: Clases de la BD a nivel BL<br/>
 Repositorio<br/>
 Servicios<br/>
+ Capa de Servicios -> PanaderiaWS<br />
Contorollers: Servicios REST<br/>

Acceso a datos -> Entity Framework<br />
Para realizar pruebas de cada servicio de utilizó <b>POSTMAN</b>
<br />

<b>Publicacion Local</b>

<img src="./local.JPG"  height = "400" alt="WS Local" />
<br />
Para su posterior uso los servicios web se alojaron localmente en IIS, para su ejecución es necesario habilitar el mismo mediante el panel de control. Una vez habilitado en un navegador color la siguiente URL:
http://localhost/PanaderiaWS/.
</br>
Ademas se uso <b> SWAGGER </b> para un mejor manejo de los servicios sin necesidad de utilizar un tercero como POSTMAN. Para ejecutar Swagger en el servidor local usar la siguiente URL: http://localhost/PanaderiaWS/swagger
</br>

<b>Base de datos</b>
<img src="./bd.JPG"  height = "400" alt="BD" /></br>
Se adjunta backup.
