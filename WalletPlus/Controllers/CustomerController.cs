using Microsoft.AspNetCore.Mvc;
using WalletPlus.Web.Data.Repositories.Interface;
using WalletPlus.Web.WebData.Entities;

namespace WalletPlus.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer, Guid> _CustomerRepo;

        public CustomerController(IRepository<Customer, Guid> customerRepo)
        {
            _CustomerRepo = customerRepo;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _CustomerRepo.GetAll();
            return View(customer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Customer { DateOfBirth = DateTime.Now, Active = true };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                await _CustomerRepo.Create(model);
                return RedirectToAction("Index", "Customers");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _CustomerRepo.Edit(id);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Customer model)
        {
            await _CustomerRepo.Update(model);

            return RedirectToAction("Index", "Customers");
        }
        public async Task<IActionResult> GetId(Guid id)
        {
            var model = await _CustomerRepo.GetSingle(id);
            return View(model);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _CustomerRepo.Delete(id);

            return RedirectToAction("Index", "Customers");
        }

    }
}
