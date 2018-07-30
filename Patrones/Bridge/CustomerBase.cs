using System;

namespace Patrones.Bridge
{
    public class CustomerBase
    {
        private DataObject _dataObject;
        private string group;

        protected CustomerBase(string group)
        {
            this.group = group;
        }
 
      

        public DataObject Data
        {
            set => _dataObject = value;
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }
        
        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }
 
        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }
 
        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }
 
        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        protected virtual void ShowAll()
        {
            Console.WriteLine("Grupo: " + group);
            _dataObject.ShowAllRecords();
        }

    }
}