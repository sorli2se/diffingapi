/*
 * Swagger diff server
 *
 * This is a sample diff server.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using IO.Swagger.Logic;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RightApiController : ControllerBase
    {
        private Dictionary<long, string> rightPageDict = null;
        private readonly IDiff Idiff = null;
        public RightApiController()
        {
            rightPageDict = Startup.getRightPageDict();
            Idiff = new Diff();
        }

        /// <summary>
        /// Update an right side
        /// </summary>

        /// <param name="diffId">ID of content to update</param>
        /// <param name="body">Right object that needs to be added for the diff</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        [HttpPut]
        [Route("/v1/diff/{diffId}/right")]
        [ValidateModelState]
        [SwaggerOperation("UpdateRight")]
        public virtual IActionResult UpdateRight([FromRoute][Required] long? diffId, [FromBody] RequestBody body)
        {
            if (diffId == null || body.Data == null)
            {
                return StatusCode(400);
            }

            Idiff.Add(rightPageDict, (long)diffId, body);

            return StatusCode(201);
        }
    }
}