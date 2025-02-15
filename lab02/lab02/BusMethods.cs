using System;
using System.Collections.Generic;//обобщенные коллекци
using System.Collections.Specialized;//специализированные коллекции
using System.Linq;
using System.Text;
using System.Threading.Tasks;//Позволяет выполнять задачи в фоновом режиме не блокируя основной поток выполнения программы.
using System.Text.RegularExpressions;// для поиска и замены строк с использованием шаблонов.


 
namespace Cars
{
    partial class Bus
    {
        public Bus(int busNumber, int routeNumber, short startYear, int mileage, string driverLastName = null, string driverInitials = null, string busBrand = "MAZ")
        {
            _driverLastName = driverLastName;
            _driverInitials = driverInitials;
            _busNumber = busNumber;
            _routeNumber = routeNumber;
            _busBrand = busBrand;
            _startYear = startYear;
            _mileage = mileage;

            Id = GetHashCode();
        }

        public Bus(string lastName, int busNumber, short startYear)
        {
            _startYear = startYear;
            _driverLastName = lastName;
            _busNumber = busNumber;
            _numberOfBuses++;

            Id = GetHashCode();
        }

        public Bus(int busNumber, int routeNumber, string busBrand = "MAZ")
        {
            _routeNumber = routeNumber;
            _busNumber = busNumber;
            _busBrand = busBrand;
            _numberOfBuses++;

            Id = GetHashCode();//идентификации объекта
        }

        //private Bus() { }


        public void ChangeingBusDrivers(ref Bus bus1, ref Bus bus2)
        {
            string buffer = bus1._driverLastName;
            bus1._driverLastName = bus2._driverLastName;
            bus2._driverLastName = buffer;

            buffer = bus1._driverInitials;
            bus1._driverInitials = bus2._driverInitials;
            bus2._driverInitials = buffer;
        }


        public int GetAgeOfBus()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - this._startYear;//разница эксплуатации и текущего года
        }
        public string GetDriver()
        {
            return _driverLastName + _driverInitials;//имя водителя
        }
        public override string ToString()//переопределение для Предоставление информативного представления
        {
            return ($"Компания: {Bus.NameOfCompany}\nid: {this.Id}\n" +
                $"Водитель: {this._driverLastName} {this._driverInitials}\n" +
                $"Марка автобуса: {this._busBrand}\nНомер автобуса: {this._busNumber}\n" +
                $"Год начала эксплуатации: {this._startYear}\nПробег: {this._mileage}\n" +
                $"Маршрут #{this._routeNumber}");
        }
        public override bool Equals(object bus)// Сравнивает текущий объект с другим объектом
        {
            if (bus == null || (bus is Bus))//сравнение на передачу объектов
            {
                return false;
            }

            Bus obj = bus as Bus;
            return obj._startYear == (bus as Bus)._startYear;//сравнение год начала эксплуатации
        }

        public override int GetHashCode()//переопределение Возвращает хэш-код для объекта
        {
            return _busNumber ^ _startYear;//Метод генерирует и возвращает хэш-код
        }
    }
}
