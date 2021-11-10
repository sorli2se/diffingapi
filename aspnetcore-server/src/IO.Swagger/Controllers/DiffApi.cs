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
    public class DiffApiController : ControllerBase
    {
        private Dictionary<long, string> leftPageDict = null;
        private Dictionary<long, string> rightPageDict = null;
        private readonly IDiff Idiff = null;

        public DiffApiController()
        {
            leftPageDict = Startup.getLeftPageDict();
            rightPageDict = Startup.getRightPageDict();
            Idiff = new Diff();
        }
        /// <summary>
        /// get status of diff
        /// </summary>

        /// <param name="diffId">ID of content to update</param>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/v1/diff/{diffId}/")]
        [ValidateModelState]
        [SwaggerOperation("GetDiff")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBody), description: "OK")]
        public virtual IActionResult GetDiff([FromRoute][Required] long? diffId)
        { 
            if (diffId == null || (!leftPageDict.ContainsKey((long)diffId) || !rightPageDict.ContainsKey((long)diffId)))
            {
                return StatusCode(404);
            }

            ResponseBody rb = Idiff.Compare(leftPageDict, rightPageDict, (long)diffId);
            return StatusCode(200, rb);

        }
    }
}