using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
using FinalProject.Controllers;
using FinalProject.Models;

namespace FinalProject.Tests.Controllers {
    [TestClass]
    public class HomeControllerTest {
        [TestMethod]
        public void Index() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }

    /// <summary>
    /// Test Class for the TenantController
    /// </summary>
    [TestClass]
    public class TenantContollerTest
    {
        [TestMethod]
        public void Index()
        {
            // 1. Arrange
            TenantController tenantController = new TenantController();

            // 2. Act
            ViewResult result = tenantController.Index() as ViewResult;

            // 3. Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            Tenant tenant = new Tenant();
            Property property = new Property();

            tenant.ID = "0";
            tenant.Name = "Jeff Bezos";
            tenant.Phone = "123-456-7890";
            tenant.Property = property;
            tenant.Password = "amazonIsGr3aT!";

            TenantController tenantController = new TenantController();

            ViewResult result = tenantController.Create(tenant) as ViewResult;

            Assert.IsNotNull(tenant, result.ViewBag.Message);
        }
    }

    /// <summary>
    /// Test Class for the PropertyController Class
    /// </summary>
    [TestClass]
    public class PropertyControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 1. Arrange
            PropertyController propertyController = new PropertyController();

            // 2. Act
            ViewResult result = propertyController.Index() as ViewResult;

            // 3. Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // 1. Arrange
            // Create the Ticket, Property, and Tenant objects
            Ticket ticket_1 = new Ticket();
            Property property = new Property();
            Tenant tenant_1 = new Tenant();

            // Set the corresponding properties
            ticket_1.ID = "0";
            ticket_1.Issuer = "John Smith";
            ticket_1.Location = "123 Lane Way";
            ticket_1.OpenTime = "";

            property.ID = "0";
            property.Address = "123 Lane Way";

            tenant_1.ID = "0";
            tenant_1.Name = "John Smith";
            tenant_1.Phone = "123-456-7890";
            tenant_1.Property = property;

            // Declare & initialize a List of Tickets
            List<Ticket> tickets = new List<Ticket>()
            {
                ticket_1
            };

            // Declare & Initialize a List of Tenants
            List<Tenant> tenants = new List<Tenant>()
            {
                tenant_1
            };
            
            // Bind the Lists
            property.Tenants = tenants;
            property.Tickets = tickets;
            

            PropertyController propertyController = new PropertyController();

            // 2. Act
            ViewResult result = propertyController.Create() as ViewResult;

            // 3. Assert
            Assert.IsNotNull(property, result.ViewBag.Message);
        }
    }

    /// <summary>
    /// Test Class for the TicketController Class
    /// </summary>
    [TestClass]
    public class TicketControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 1. Arrange
            TicketController ticketController = new TicketController();

            // 2. Act
            ViewResult result = ticketController.Index() as ViewResult;

            // 3. Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // 1. Arrange
            Ticket ticket = new Ticket();

            ticket.ID = "0";
            ticket.Issuer = "John Smith";
            ticket.Location = "123 Lane Way";
            ticket.OpenTime = "";

            TicketController ticketController = new TicketController();

            ViewResult result = ticketController.Create(ticket) as ViewResult;

            Assert.IsNotNull(ticket, result.ViewBag.Message);
        }
    }
}
