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
