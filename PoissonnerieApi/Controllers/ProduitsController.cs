﻿using BusinessEngine.Manager;
using BusinessEngine.Models;
using Newtonsoft.Json.Linq;
using PoissonnerieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoissonnerieApi.Controllers
{
    public class ProduitsController : ApiController
    {

        // GET api/produits
        public object GetAll()
        {
            ResponseData responseData;
            try
            {
                responseData = ResponseData.GetSuccess(DataManager.GetAllProduits());
            }
            catch (Exception ex)
            {
                responseData = ResponseData.GetError(ex.Message);
            }

            return responseData;
        }

        // GET api/produits/5
        public object Get(int id)
        {
            ResponseData responseData;
            try
            {
                responseData = ResponseData.GetSuccess(DataManager.GetCategorie(id));
            }
            catch (Exception ex)
            {
                responseData = ResponseData.GetError(ex.Message);
            }

            return responseData;
        }

        // POST api/produits
        public object Post([FromBody]JToken data)
        {
            ResponseData responseData;
            try
            {
                var _data = data.ToObject<Produit>();
                if (_data.Id > 0)
                {
                    _data.DateModification = DateTime.UtcNow;
                }else{
                    _data.DateCreation = DateTime.UtcNow;
                }

                DataManager.Save(_data);
                responseData = ResponseData.GetSuccess(_data);
            }
            catch (Exception ex)
            {
                responseData = ResponseData.GetError(ex.Message);
            }

            return responseData;
        }
    }
}