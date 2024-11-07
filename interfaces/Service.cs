namespace service{

    public class Controller{
        private readonly IService _service;
        public Controller(IService service){
            this._service = service;
        }
        public void Add(){
            _service.Add();
        }
        public void Uopdate(){
            _service.Update();
        }
    }
    public interface IRepository{
        void Add();
        void Update();
    }
    public class Repository : IRepository
    {
        public void Add()
        {
            
        }

        public void Update()
        {
            
        }
    }
    /*
        no puedes hacer un new
    */
    public interface IService{
        void Add();
        void Update();
    }

    /*
        IService service = new Service();
    */
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository){
            this._repository = repository;
        }

        public void Add()
        {
            _repository.Add();
        }

        public void Update()
        {
            _repository.Update();
        }
    }
}