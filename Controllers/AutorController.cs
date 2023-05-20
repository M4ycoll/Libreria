using System.Net;
using Microsoft.AspNetCore.Mvc;
using libreria.Models;

namespace libreria.Controllers;
 
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("[controller]")]
public class AutorController: ControllerBase
{
    //CRUD API
    //ATRIBUTOS DE ENDPOINTS

    //CREATE
    [HttpPost]
    public IActionResult ingresarAutores([FromBody] Autor nuevoAutor){
        //... Logica para POST
        return Ok();
    }

    //READ
    [HttpGet]
    public IActionResult mostrarAutores(){
        //... Logica para GET
        return Ok();
    }

    //UPDATE
    [HttpPut("{id}")]
    public IActionResult actualizarAutores([FromBody] Autor autorActualizar, string id){
        //... Logica para UPDATE
        return Ok();
    }

    //DELETE
    [HttpDelete("{id}")]
    public IActionResult eliminarAutores(){
        //... Logica para DELETE
        return Ok();
    }
}