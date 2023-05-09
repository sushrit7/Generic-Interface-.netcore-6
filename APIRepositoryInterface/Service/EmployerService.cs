using APIRepositoryInterface.Interface;
using APIRepositoryInterface.Models;

namespace APIRepositoryInterface.Service
{
    public class EmployerService : IGenericService<Employer>
    {
        List<Employer>  employers = new List<Employer>();

        public EmployerService()
        {
            for (int i = 1; i < 5; i++)
            {
                employers.Add(new Employer()
                {
                    id = i,
                    Name = "Employer " + i,
                    JobTitle = "HR " + i,
                   
                }) ;
            }
        }

        public List<Employer> Delete(int id)
        {
            employers.RemoveAll(x => x.id == id);
            return employers;
        }

        public List<Employer> GetAll()
        {
            return employers;
        }

        public Employer GetById(int id)
        {
            var  employer = employers.Where(x => x.id == id)
                .FirstOrDefault();
            return employer;
        }

        public List<Employer> Insert(Employer item)
        {
            employers.Add(item);
            return employers;

        } 
    }
}
