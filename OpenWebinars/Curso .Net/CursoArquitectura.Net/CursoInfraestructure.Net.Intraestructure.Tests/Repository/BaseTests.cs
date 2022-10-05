using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities.Base;
using CursoArquitectura.Net.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;

namespace CursoInfraestructure.Net.Intraestructure.Tests.Repository
{
    public class BaseTests
    {
        private CursoArquitecturaNetContext GenerateContext(Mock<DbSet<BaseEntity>> dbSetMock)
        {
            var dbOptions = new DbContextOptionsBuilder<CursoArquitecturaNetContext>()
                .UseInMemoryDatabase(databaseName: "CursoTestingDB")
                .Options;
            var context = new Mock<CursoArquitecturaNetContext>(dbOptions);
            context.Setup(x => x.Set<BaseEntity>()).Returns(dbSetMock.Object);


            return context.Object;
        }
    }
}
