namespace Curso
{

    class Foo
    {
        public Foo(int id,string name){            
            Id =id;
            Name =name;                       
        }        
        public int Id { get; init; }
        public  string Name { get;  init; }

        public static bool operator ==(Foo a, Foo b){
            return a.Id == b.Id;
        }
        public static bool operator !=(Foo a, Foo b){
            return a.Id != b.Id;
        }
        public override bool Equals(object? obj)        
        {
            if(obj is Foo f){
                return f.Id==Id;
            }
            return false;
        }
        override public int GetHashCode(){
            return Id.GetHashCode();
        }
    }

}