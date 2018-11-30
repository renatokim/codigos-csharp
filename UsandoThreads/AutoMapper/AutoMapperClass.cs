using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThreads.AutoMapper
{
    public class AutoMapperClass
    {
        public AutoMapperClass()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDto>());
        }

        public void AutoMapperFunction()
        {
            var order = new Order 
            {

                Id = 1,
                Descricao = "teste",
                Usuario = new Usuario
                {

                    Id = 1,
                    Login = "renato.kim@hotmail.com",
                    Senha = "1234"
                }
            };

            OrderDto dto = Mapper.Map<OrderDto>(order);


        }


    }
}
