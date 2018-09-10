﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using HelpDesk.Repositorio;
using HelpDesk.Dominio.Entidades;

public class NHibernateHelper
{
    private static ISessionFactory _sessionFactory;
    private static Configuration cfg = new Configuration();

    public static ISession GetSession()
    {
        if (_sessionFactory == null)
        {
            log4net.Config.XmlConfigurator.Configure();
            lock (typeof(NHibernateHelper))
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2008//mudei aqui // MySql: MySQLConfiguration.Standard
                                .ShowSql()
                       //.ConnectionString(c => c.Is("Data Source=www.doctus.com.br;Initial Catalog=teste;User Id=testeadmin;Password=teste123;")))
                       .ConnectionString(c => c.Is(@" Server =WINDOWS10\ALESSANDRO; Database = PizzaBoing; integrated security = true;")))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<RepositorioAutenticacao>())

                     //.ExposeConfiguration(BuildSchema)

                        .BuildSessionFactory();
                }
            }
        }
        return _sessionFactory.OpenSession();
    }

    private NHibernateHelper()
    {
    }

    private static void BuildSchema(Configuration config)
    {

        //new SchemaExport(config).SetOutputFile(@"D:\Curso\HelpDesk.sql")
        //new SchemaExport(config).SetOutputFile("teste.txt");
        new SchemaExport(config).SetOutputFile(@"C:\ScriptBanco\HelpDesk.sql")

          .Create(true, true);
      
    }
}

