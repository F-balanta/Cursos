using API.DTOs;
using API.Helpers;
using API.Helpers.Errors;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [Authorize(Roles = "Administrador")]
    public class ProductosController : BaseApiController
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ProductoListDto>>> Get([FromQuery] Params productParams)
        {
            var resultado = await _unitOfWork.Productos.GetAllAsync(productParams.PageIndex, productParams.PageSize, productParams.Search);

            var listaProductosDto = _mapper.Map<List<ProductoListDto>>(resultado.registros);
            //! Enviar en el encabezado el total de registros
            Response.Headers.Add("X-InlineCount", resultado.totalRegistros.ToString());
            // Se envian los registros por pagina, el total de registros, la pagina actual y el tamaño de la pagina
            return new Pager<ProductoListDto>(listaProductosDto,resultado.totalRegistros, productParams.PageIndex, productParams.PageSize, productParams.Search);
        }


        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> Get11()
        {
            var productos = await _unitOfWork.Productos.GetAllAsync();

            return _mapper.Map<List<ProductoDto>>(productos);
            //return Ok(productos);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductoDto>> GetProduct(int id)
        {
            var producto = await _unitOfWork.Productos.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new ApiResponse(404, "El producto solicitado no existe."));

            return _mapper.Map<ProductoDto>(producto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Producto>> Post([FromBody] ProductoAddOrUpdateDto productoDto)
        {
            var producto = _mapper.Map<Producto>(productoDto);
            _unitOfWork.Productos.Add(producto);
            await _unitOfWork.Save();
            if (producto == null)
                return BadRequest(new ApiResponse(400, ""));
            productoDto.Id = producto.Id;
            return CreatedAtAction(nameof(Post), new { id = productoDto.Id }, productoDto);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductoAddOrUpdateDto>> Put(int id, [FromBody] ProductoAddOrUpdateDto productoDto)
        {
            if (productoDto == null)
                return NotFound(new ApiResponse(404, "El producto solicitado no existe."));
            var producto = _mapper.Map<Producto>(productoDto);
            _unitOfWork.Productos.Update(producto);
            await _unitOfWork.Save();

            return productoDto;
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var productoBuscar = await _unitOfWork.Productos.GetByIdAsync(id);
            if (productoBuscar == null)
                return NotFound(new ApiResponse(404, "El producto solicitado no existe."));

            _unitOfWork.Productos.Remove(productoBuscar);
            await _unitOfWork.Save();
            return NoContent();
        }
    }
}