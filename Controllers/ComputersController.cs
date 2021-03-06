using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using computer_store_MVC.Models;
using computer_store_MVC.Dtos;
using computer_store_MVC.ViewModels;

namespace computer_store_MVC.Controllers
{
    public class ComputersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ComputersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Computers
        public ActionResult Index()
        {
            List<Computer> computers = _context.Computers.ToList();
            var computersDto = computers.Select(Mapper.Map<Computer, ComputerDto>).ToList();

            var viewModel = new ComputersViewModel()
            {
                Computers = computersDto
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var computer = _context.Computers.SingleOrDefault(comp => comp.Id == id);
            if (computer == null) return HttpNotFound();

            var computerDto = Mapper.Map<Computer, ComputerDto>(computer);

            return View(computerDto);
        }

        public ActionResult New()
        {
            var computerDto = new ComputerDto();

            return View("ComputerForm", computerDto);
        }

        public ActionResult Edit(int id)
        {
            var computer = _context.Computers.SingleOrDefault(c => c.Id == id);

            if (computer == null) return HttpNotFound();

            var computerDto = Mapper.Map<Computer, ComputerDto>(computer);

            return View("ComputerForm", computerDto);
        }

        public ActionResult Save(ComputerDto computerDto)
        {
            if (!ModelState.IsValid) return View("ComputerForm", computerDto);

            if (computerDto.Id == 0)
            {
                var computer = Mapper.Map<ComputerDto, Computer>(computerDto);
                _context.Computers.Add(computer);
            }
            else
            {
                var computerInDb = _context.Computers.Single(c => c.Id == computerDto.Id);
                Mapper.Map(computerDto, computerInDb);
            }


            _context.SaveChanges();
            return RedirectToAction("", "Computers");
        }

        public ActionResult Delete(int id)
        {
            var computerInDb = _context.Computers.SingleOrDefault(c => c.Id == id);

            if (computerInDb == null)
                return HttpNotFound();

            _context.Computers.Remove(computerInDb);
            _context.SaveChanges();

            return RedirectToAction("", "Computers");
        }
    }
}