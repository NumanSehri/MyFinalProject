﻿using Business.Abstract;
using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Swagger
        //Loosely coupled
        //naming convetion
        //IoC Container------ Inversion Of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() // Getir
        {
            
             
            var result = _productService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);

            }
            return BadRequest(result);
            
        }
        [HttpPost("Add")] //veri gönder
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Succes)
            {
                return Created(result.Messages, product);

            }
            return BadRequest(result);
        }
        [HttpGet("CategoryById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetAllCategoryId(id);
                if (result.Succes)
                {

                    return Ok(result);

                }
                    return BadRequest(result);
        }

        
    }
}
