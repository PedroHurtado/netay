namespace service{

    public interface IGet{
        void Get();
    }
    public interface IAdd{
        void Add();
    }
    public interface IUpdate:IGet  {
        void Update();
    }
    public interface IRemove:IGet{
        void Remove();
    }

    public interface IRepository: IAdd,IUpdate, IRemove {}

    public class Repository : IRepository
    {
        public void Add()
        {
            
        }

        public void Get()
        {
            
        }

        public void Remove()
        {
            
        }

        public void Update()
        {
            
        }
    }


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
        {   _repository.Get();
            _repository.Update();
        }
    }
}