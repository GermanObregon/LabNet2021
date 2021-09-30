using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.AccesData.Command.Repository;
using Tp4.AccesData.Queries.Repository;
using Tp4.AccesData.Validations;
using Tp4.Domain.Models;

namespace Tp7.Service
{
    public interface IShippersService
    {
        List<Shippers> GetAllShippers();
        void AddShipper(Shippers shipper);
        void DeleteShipper(int id);
        void UpdateShipper(Shippers shipper);
        Shippers GetById(int id);

    }

    public class ShippersService : IShippersService
    {
        private readonly ICompaniasEnviosQuery Query;
        private readonly IGenericRepository Command;
        public ShippersService(ICompaniasEnviosQuery companiasEnviosQuery , IGenericRepository repositorio)
        {
            this.Query = companiasEnviosQuery;
            this.Command = repositorio;
        }

        public void AddShipper(Shippers shipper)
        {
            try
            {
                ValidarShipper(shipper);
                Command.Add<Shippers>(shipper);

                
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }


        public List<Shippers> GetAllShippers()
        {
            try
            {
                return Query.GetShippers();
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
       

        public void DeleteShipper(int id)
        {
            try
            {
                Command.Delete<Shippers>(id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateShipper(Shippers shipper)
        {
            try
            {
                ValidarShipper(shipper);
                Command.Update<Shippers>(shipper);

            }
            catch (Exception e)
            {

                throw e;
            }
            
        }


        private static void ValidarShipper(Shippers shipper)
        {
            var validar = new ShipperValidator();
            validar.ValidateAndThrow(shipper);
        }

        public Shippers GetById(int id)
        {
            return Query.GetShipperById(id);
        }
    }
}
