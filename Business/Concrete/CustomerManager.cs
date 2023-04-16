using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrosCutingConcerns.Validations;
using Core.Utilities;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetByCustomerId(string id)
        {
            return _customerDal.GetAll(c=>c.CustomerId == id);
        }

        public IResult Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(),customer);
            _customerDal.Add(customer);
            return new SuccessResult("Customer Eklendi");
        }

        public IResult Update(Customer custoemr)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
