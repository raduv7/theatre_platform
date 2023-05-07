using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public abstract class AbstractTableEntity : IAbstractTableEntity
    {
        private int _id;
    
        protected AbstractTableEntity()
        {
            this._id = 0;
        }
    
        protected AbstractTableEntity(int id)
        {
            this._id = id;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}