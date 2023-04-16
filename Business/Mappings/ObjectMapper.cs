using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappings
{
   public class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });
            return config.CreateMapper();

        });
        public static IMapper Mapper => lazy.Value;
    }
}
